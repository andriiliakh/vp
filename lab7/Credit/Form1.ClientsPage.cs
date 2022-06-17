using Credit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Credit
{
    partial class Form1
    {
        private void CalculateRating(ref List<Clients> clients)
        {
            var credits = context.Credits.ToList();
            var paymentSchedule = context.PaymentSchedule.ToList();
            foreach (var client in clients)
            {
                if (client is null)
                    continue;
                client.LastUpdated = DateTime.UtcNow;
                var credit = credits.FirstOrDefault(y => y.ClientId == client.Id);
                if (credit is null)
                    continue;
                var payments = paymentSchedule.Where(x => x.CreditId == credit.Id);
                var sum = payments.Sum(x => x.Amount);
                var part1 = (sum + payments.Sum(x => x.InterestRate)) / (DateTime.Now - credit.StartDate).Days;
                var part2 = payments.Where(x => !x.IsPaid).Sum(x => x.Amount) / ((payments.LastOrDefault().PaymentDate - payments.FirstOrDefault().PaymentDate).Days - (DateTime.Now - credit.StartDate).Days);
                var isTherePaid = payments.LastOrDefault(x => x.IsPaid) != null;
                var advanceDays = isTherePaid ? (DateTime.Now - payments.LastOrDefault(x => x.IsPaid).PaymentDate).Days : 0;
                advanceDays = advanceDays > 0 ? advanceDays : 0;
                var expiredDays = advanceDays > 0 ? 0 : advanceDays;
                if (!isTherePaid)
                    expiredDays = (DateTime.Now - payments.FirstOrDefault().PaymentDate).Days;
                var exp1 = advanceDays == 0 ? 0 : Math.Exp(-advanceDays);
                var exp2 = Math.Exp(-expiredDays);
                var res = part1 - part2 + exp1 - exp2;
                client.Rating = Math.Round(res, 2);
                if (res > 100000)
                    client.Rating = 100000;
                else if (res < -100000)
                    client.Rating = -100000;
            }
        }

        private void ClientsSaveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ClientsTable.Rows)
            {
                var client = row.DataBoundItem as Clients;
                if (client is null)
                    continue;
                var dbClient = context.Clients.Find(client.Id);
                if (dbClient != null)
                {
                    dbClient = client;
                }
                else
                {
                    context.Clients.Add(client);
                }
            }
            context.SaveChanges();
        }

        private void ClientsRefreshButton_Click(object sender, EventArgs e)
        {
            foreach (var entity in context.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            ClientsTable.DataSource = new BindingList<Clients>(context.Clients.ToList());
            ClientsTable.Invalidate();
        }

        private void ClientsRatingButton_Click(object sender, EventArgs e)
        {
            var clients = (ClientsTable.DataSource as BindingList<Clients>).ToList();
            this.CalculateRating(ref clients);
            ClientsTable.DataSource = new BindingList<Clients>(clients);
        }

        private void ClientsOrderButton_Click(object sender, EventArgs e)
        {
            var clients = (ClientsTable.DataSource as BindingList<Clients>).ToList();
            clients = clients.OrderByDescending(x => x.Rating).ToList();
            ClientsTable.DataSource = new BindingList<Clients>(clients);
        }

        private void ClientsDeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ClientsTable.SelectedRows)
            {
                var client = row.DataBoundItem as Clients;
                if (client is null)
                    continue;
                var dbClient = context.Clients.Find(client.Id);
                if (dbClient is null)
                    continue;
                context.Clients.Remove(dbClient);
            }
            context.SaveChanges();
            this.ClientsRefreshButton.PerformClick();
        }
    }
}

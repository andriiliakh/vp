using Credit.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Credit
{
    public partial class Form1
    {
        private void CreditsValidation(object sender, DataGridViewCellEventArgs e)
        {
            var cell = CreditsTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var headerText = CreditsTable.Columns[e.ColumnIndex].HeaderText;
            if (!headerText.Equals("ClientId")) return;

            var client = context.Clients.Find(int.Parse(cell.Value.ToString()));
            if (client is null)
            {
                MessageBox.Show("There is no client with such id", "Error");
                CreditsTable.Rows.RemoveAt(e.RowIndex);
                CreditsRefreshButton.PerformClick();
            }
            var credits = context.Credits.Where(x => x.ClientId == client.Id).ToList();
            if (credits is null) return;
            foreach (var credit in credits)
            {
                var paymentSchedules = context.PaymentSchedule.Where(x => x.CreditId == credit.Id).ToList();
                var lastPayment = paymentSchedules.Last();
                if (!lastPayment.IsPaid && lastPayment.PaymentDate < DateTime.UtcNow)
                {
                    MessageBox.Show($"Client has outdated credit. Credit id: {credit.Id}", "Error");
                    break;
                }
                if (paymentSchedules.Any(x=>!x.IsPaid && x.PaymentDate < DateTime.UtcNow))
                {
                    MessageBox.Show($"Client don't pay according to payment schedule", "Error");
                    break;
                }
                var clientRatingIndex = context.Clients.OrderByDescending(x => x.Rating).ToList().FindIndex(x => x.Id == client.Id);
                if (clientRatingIndex >= 3 * context.Clients.Count() / 4)
                {
                    MessageBox.Show($"Unfortunately client rating index is in 4 quarter", "Error");
                    break;
                }
                return;
            }
            CreditsTable.Rows.RemoveAt(e.RowIndex);
            CreditsRefreshButton.PerformClick();
        }

        private void CreditsRefreshButton_Click(object sender, EventArgs e)
        {
            foreach (var entity in context.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            CreditsTable.DataSource = new BindingList<Credits>(context.Credits.ToList());
            CreditsTable.Invalidate();
        }

        private void CreditsSaveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in CreditsTable.Rows)
            {
                var credit = row.DataBoundItem as Credits;
                if (credit is null)
                    continue;
                var dbCredit = context.Credits.Find(credit.Id);
                if (dbCredit != null)
                {
                    dbCredit = credit;
                    dbCredit.LastUpdated = DateTime.Now;
                }
                else
                {
                    context.Credits.Add(credit);
                }
            }
            context.SaveChanges();
        }

        private void CreditsDeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in CreditsTable.SelectedRows)
            {
                var credit = row.DataBoundItem as Credits;
                if (credit is null)
                    continue;
                var dbCredit = context.Credits.Find(credit.Id);
                if (dbCredit is null)
                    continue;
                context.Credits.Remove(dbCredit);
            }
            context.SaveChanges();
            this.CreditsRefreshButton.PerformClick();
        }
    }
}

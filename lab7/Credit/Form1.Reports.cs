using Credit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Credit
{
    public partial class Form1
    {
        private void FillPercentReport()
        {
            var credits = context.Credits.ToList();
            var template = new { CreditId = 0, ClientId = 0, Percent = 1.1 };
            var template2 = new { CreditId = 0, ClientId = 0, Percent = 1.1 };
            var list = new[] { template, template2 }.ToList();
            list.Clear();
            foreach (var credit in credits)
            {
                var paymentSchedule = context.PaymentSchedule.Where(x => x.CreditId == credit.Id).ToList();
                var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var outdatedPayment = paymentSchedule.FirstOrDefault(x => !x.IsPaid && x.PaymentDate > startDate && x.PaymentDate < DateTime.UtcNow);
                if (outdatedPayment is null)
                {
                    continue;
                }
                var outdatedDays = (DateTime.Now - outdatedPayment.PaymentDate).Days;
                var sum = paymentSchedule.Sum(x => x.Amount)/credit.Duration;
                var sumWithPercents = CalculatePercents(sum, outdatedDays);
                var percent = Math.Round(sumWithPercents - sum, 2);
                if (Math.Abs(percent) < 1)
                    continue;
                list.Add(new { CreditId = credit.Id, ClientId = credit.ClientId, Percent = percent });
            }
            PercentReporpTable.DataSource = list;
        }

        private void FillDebtReport()
        {
            var credits = context.Credits.ToList();
            var template = new { CreditId = 0, ClientId = 0, Name = "", Surname = "",DebtAmount = 1.1 };
            var template2 = new { CreditId = 0, ClientId = 0, Name = "", Surname = "", DebtAmount = 1.1 };
            var list = new[] { template, template2 }.ToList();
            list.Clear();
            foreach (var credit in credits)
            {
                var paymentSchedule = context.PaymentSchedule.Where(x => x.CreditId == credit.Id).ToList();
                var outdatedPayments = paymentSchedule.Where(x => !x.IsPaid  && x.PaymentDate < DateTime.UtcNow);
                if (outdatedPayments is null)
                {
                    continue;
                }
                var sum = outdatedPayments.Sum(x => x.Amount);
                if (Math.Abs(sum) < 1)
                    continue;
                var client = context.Clients.ToList().First(x => x.Id == credit.ClientId);
                list.Add(new { CreditId = credit.Id, ClientId = client.Id, Name = client.Name, Surname = client.Surname, DebtAmount = Math.Round(sum,2)});
            }
            DebtTable.DataSource = list;
        }



        private void ShowOPReportButton_Click(object sender, EventArgs e)
        {
            var credits = context.Credits.ToList();
            var template = new { CreditId = 0, ClientId = 0, Name = "", Surname = "", OverpaidAmount = 1.1 };
            var template2 = new { CreditId = 0, ClientId = 0, Name = "", Surname = "", OverpaidAmount = 1.1 };
            var list = new[] { template, template2 }.ToList();
            list.Clear();
            foreach (var credit in credits)
            {
                var paymentSchedule = context.PaymentSchedule.Where(x => x.CreditId == credit.Id).ToList();
                var Payments = paymentSchedule.Where(x => x.IsPaid && x.PaymentDate > monthCalendar1.SelectionRange.Start && credit.StartDate < monthCalendar1.SelectionRange.Start);
                if (Payments is null)
                {
                    continue;
                }
                var sum = Payments.Sum(x => x.Amount);
                if (Math.Abs(sum) < 1)
                    continue;
                var client = context.Clients.ToList().First(x => x.Id == credit.ClientId);
                list.Add(new { CreditId = credit.Id, ClientId = client.Id, Name = client.Name, Surname = client.Surname, OverpaidAmount = Math.Round(sum, 2) });
            }
            OverpaymentTable.DataSource = list;
        }
    }
}

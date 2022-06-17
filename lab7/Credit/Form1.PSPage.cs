using Credit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Credit
{
    public partial class Form1
    {
        private void PSRefreshButton_Click(object sender, EventArgs e)
        {
            foreach (var entity in context.ChangeTracker.Entries())
            {
                entity.Reload();
            }
            PaymentScheduleTable.DataSource = new BindingList<PaymentSchedule>(context.PaymentSchedule.ToList());
            PaymentScheduleTable.Invalidate();
        }

        private void PSSaveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PaymentScheduleTable.Rows)
            {
                var paymentSchedule = row.DataBoundItem as PaymentSchedule;
                if (paymentSchedule is null)
                    continue;
                var dbPaymentSchedule = context.PaymentSchedule.Find(paymentSchedule.Id);
                if (dbPaymentSchedule != null)
                {
                    dbPaymentSchedule = paymentSchedule;
                    dbPaymentSchedule.LastUpdated = DateTime.Now;
                }
                else
                {
                    context.PaymentSchedule.Add(paymentSchedule);
                }
            }
            context.SaveChanges();
        }

        private void PSDeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PaymentScheduleTable.SelectedRows)
            {
                var paymentSchedule = row.DataBoundItem as PaymentSchedule;
                if (paymentSchedule is null)
                    continue;
                var dbPaymentSchedule = context.PaymentSchedule.Find(paymentSchedule.Id);
                if (dbPaymentSchedule is null)
                    continue;
                context.PaymentSchedule.Remove(dbPaymentSchedule);
            }
            context.SaveChanges();
            this.PSRefreshButton.PerformClick();
        }


        private void PSUpdateButton_Click(object sender, EventArgs e)
        {
            var credits = context.Credits.ToList();
            var PSres = new List<PaymentSchedule>();
            foreach (var credit in credits)
            {
                var paymentSchedule = context.PaymentSchedule.Where(x => x.CreditId == credit.Id).ToList();
                var outdatedPayment = paymentSchedule.FirstOrDefault(x => !x.IsPaid && x.PaymentDate > x.LastUpdated && x.PaymentDate < DateTime.UtcNow);
                if (outdatedPayment is null)
                {
                    PSres.AddRange(paymentSchedule);
                    continue;
                }
                var outdatedDays = (DateTime.Now - outdatedPayment.PaymentDate).Days;
                var sum = paymentSchedule.Sum(x => x.Amount);
                var sumWithPercents = CalculatePercents(sum, outdatedDays);
                var lastPayment = paymentSchedule.Last();
                if (!credit.IsOutdated && (DateTime.Now - lastPayment.PaymentDate).Days>10)
                {
                    sumWithPercents += sumWithPercents*0.1;
                    credit.IsOutdated = true;
                    credit.LastUpdated = DateTime.UtcNow;
                }
                var notPaidpayments = paymentSchedule.Where(x => !x.IsPaid).ToList();
                foreach (var payment in paymentSchedule)
                {
                    if (!payment.IsPaid)
                    {
                        payment.Amount += Math.Round((sumWithPercents - sum) / notPaidpayments.Count, 2);
                        payment.LastUpdated = DateTime.UtcNow;
                    }
                }
                PSres.AddRange(paymentSchedule);
            }
            PaymentScheduleTable.DataSource = new BindingList<PaymentSchedule>(PSres);
            CreditsTable.DataSource = new BindingList<Credits>(credits);
            CreditsSaveButton.PerformClick();
            PSSaveButton.PerformClick();
        }

        private double CalculatePercents(double amount, int days)
        {
            for (int i = 0; i < days; i++)
                amount += amount * 0.01;
            return amount;
        }

    }
}

using Credit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Credit
{
    public partial class Form1 : Form
    {
        public CreditsDbEntities context = new CreditsDbEntities();

        public Form1()
        {
            InitializeComponent();
            ClientsTable.DataSource = new BindingList<Clients>(context.Clients.ToList());
            CreditsTable.DataSource = new BindingList<Credits>(context.Credits.ToList());
            PaymentScheduleTable.DataSource = new BindingList<PaymentSchedule>(context.PaymentSchedule.ToList());
            FillPercentReport();
            FillDebtReport();
        }
    }
}

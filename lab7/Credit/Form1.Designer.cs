namespace Credit
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ClientsDeleteButton = new System.Windows.Forms.Button();
            this.ClientsOrderButton = new System.Windows.Forms.Button();
            this.ClientsRatingButton = new System.Windows.Forms.Button();
            this.ClientsRefreshButton = new System.Windows.Forms.Button();
            this.ClientsSaveButton = new System.Windows.Forms.Button();
            this.ClientsTable = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PSUpdateButton = new System.Windows.Forms.Button();
            this.PSDeleteButton = new System.Windows.Forms.Button();
            this.PSRefreshButton = new System.Windows.Forms.Button();
            this.PSSaveButton = new System.Windows.Forms.Button();
            this.PaymentScheduleTable = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.PercentReporpTable = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.CreditsRefreshButton = new System.Windows.Forms.Button();
            this.CreditsSaveButton = new System.Windows.Forms.Button();
            this.CreditsTable = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DebtTable = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.ShowOPReportButton = new System.Windows.Forms.Button();
            this.OverpaymentTable = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legalAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiefInitialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualInterestRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pledgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.paymentScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsTable)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentScheduleTable)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentReporpTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditsTable)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DebtTable)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OverpaymentTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentScheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ClientsDeleteButton);
            this.tabPage1.Controls.Add(this.ClientsOrderButton);
            this.tabPage1.Controls.Add(this.ClientsRatingButton);
            this.tabPage1.Controls.Add(this.ClientsRefreshButton);
            this.tabPage1.Controls.Add(this.ClientsSaveButton);
            this.tabPage1.Controls.Add(this.ClientsTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ClientsDeleteButton
            // 
            this.ClientsDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClientsDeleteButton.AutoSize = true;
            this.ClientsDeleteButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientsDeleteButton.Location = new System.Drawing.Point(94, 344);
            this.ClientsDeleteButton.Name = "ClientsDeleteButton";
            this.ClientsDeleteButton.Size = new System.Drawing.Size(81, 47);
            this.ClientsDeleteButton.TabIndex = 6;
            this.ClientsDeleteButton.Text = "Delete";
            this.ClientsDeleteButton.UseVisualStyleBackColor = false;
            this.ClientsDeleteButton.Click += new System.EventHandler(this.ClientsDeleteButton_Click);
            // 
            // ClientsOrderButton
            // 
            this.ClientsOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClientsOrderButton.AutoSize = true;
            this.ClientsOrderButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientsOrderButton.Location = new System.Drawing.Point(396, 344);
            this.ClientsOrderButton.Name = "ClientsOrderButton";
            this.ClientsOrderButton.Size = new System.Drawing.Size(109, 47);
            this.ClientsOrderButton.TabIndex = 5;
            this.ClientsOrderButton.Text = "Order";
            this.ClientsOrderButton.UseVisualStyleBackColor = false;
            this.ClientsOrderButton.Click += new System.EventHandler(this.ClientsOrderButton_Click);
            // 
            // ClientsRatingButton
            // 
            this.ClientsRatingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClientsRatingButton.AutoSize = true;
            this.ClientsRatingButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientsRatingButton.Location = new System.Drawing.Point(281, 344);
            this.ClientsRatingButton.Name = "ClientsRatingButton";
            this.ClientsRatingButton.Size = new System.Drawing.Size(109, 47);
            this.ClientsRatingButton.TabIndex = 4;
            this.ClientsRatingButton.Text = "Calculate rating";
            this.ClientsRatingButton.UseVisualStyleBackColor = false;
            this.ClientsRatingButton.Click += new System.EventHandler(this.ClientsRatingButton_Click);
            // 
            // ClientsRefreshButton
            // 
            this.ClientsRefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClientsRefreshButton.AutoSize = true;
            this.ClientsRefreshButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientsRefreshButton.Location = new System.Drawing.Point(181, 344);
            this.ClientsRefreshButton.Name = "ClientsRefreshButton";
            this.ClientsRefreshButton.Size = new System.Drawing.Size(94, 47);
            this.ClientsRefreshButton.TabIndex = 3;
            this.ClientsRefreshButton.Text = "Refresh data";
            this.ClientsRefreshButton.UseVisualStyleBackColor = false;
            this.ClientsRefreshButton.Click += new System.EventHandler(this.ClientsRefreshButton_Click);
            // 
            // ClientsSaveButton
            // 
            this.ClientsSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClientsSaveButton.AutoSize = true;
            this.ClientsSaveButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientsSaveButton.Location = new System.Drawing.Point(6, 344);
            this.ClientsSaveButton.Name = "ClientsSaveButton";
            this.ClientsSaveButton.Size = new System.Drawing.Size(82, 47);
            this.ClientsSaveButton.TabIndex = 2;
            this.ClientsSaveButton.Text = "Save";
            this.ClientsSaveButton.UseVisualStyleBackColor = false;
            this.ClientsSaveButton.Click += new System.EventHandler(this.ClientsSaveButton_Click);
            // 
            // ClientsTable
            // 
            this.ClientsTable.AllowUserToOrderColumns = true;
            this.ClientsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsTable.AutoGenerateColumns = false;
            this.ClientsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ClientsTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ClientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.taxCodeDataGridViewTextBoxColumn,
            this.legalAddressDataGridViewTextBoxColumn,
            this.actualAddressDataGridViewTextBoxColumn,
            this.chiefInitialsDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.ClientsTable.DataSource = this.clientsBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientsTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.ClientsTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientsTable.Location = new System.Drawing.Point(6, 6);
            this.ClientsTable.Name = "ClientsTable";
            this.ClientsTable.RowHeadersWidth = 51;
            this.ClientsTable.RowTemplate.Height = 24;
            this.ClientsTable.Size = new System.Drawing.Size(759, 332);
            this.ClientsTable.TabIndex = 1;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PSUpdateButton);
            this.tabPage3.Controls.Add(this.PSDeleteButton);
            this.tabPage3.Controls.Add(this.PSRefreshButton);
            this.tabPage3.Controls.Add(this.PSSaveButton);
            this.tabPage3.Controls.Add(this.PaymentScheduleTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Payment schedule";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PSUpdateButton
            // 
            this.PSUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PSUpdateButton.AutoSize = true;
            this.PSUpdateButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.PSUpdateButton.Location = new System.Drawing.Point(281, 341);
            this.PSUpdateButton.Name = "PSUpdateButton";
            this.PSUpdateButton.Size = new System.Drawing.Size(120, 47);
            this.PSUpdateButton.TabIndex = 15;
            this.PSUpdateButton.Text = "Update schedule";
            this.PSUpdateButton.UseVisualStyleBackColor = false;
            this.PSUpdateButton.Click += new System.EventHandler(this.PSUpdateButton_Click);
            // 
            // PSDeleteButton
            // 
            this.PSDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PSDeleteButton.AutoSize = true;
            this.PSDeleteButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.PSDeleteButton.Location = new System.Drawing.Point(94, 341);
            this.PSDeleteButton.Name = "PSDeleteButton";
            this.PSDeleteButton.Size = new System.Drawing.Size(81, 47);
            this.PSDeleteButton.TabIndex = 14;
            this.PSDeleteButton.Text = "Delete";
            this.PSDeleteButton.UseVisualStyleBackColor = false;
            this.PSDeleteButton.Click += new System.EventHandler(this.PSDeleteButton_Click);
            // 
            // PSRefreshButton
            // 
            this.PSRefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PSRefreshButton.AutoSize = true;
            this.PSRefreshButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.PSRefreshButton.Location = new System.Drawing.Point(181, 341);
            this.PSRefreshButton.Name = "PSRefreshButton";
            this.PSRefreshButton.Size = new System.Drawing.Size(94, 47);
            this.PSRefreshButton.TabIndex = 13;
            this.PSRefreshButton.Text = "Refresh data";
            this.PSRefreshButton.UseVisualStyleBackColor = false;
            this.PSRefreshButton.Click += new System.EventHandler(this.PSRefreshButton_Click);
            // 
            // PSSaveButton
            // 
            this.PSSaveButton.AllowDrop = true;
            this.PSSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PSSaveButton.AutoSize = true;
            this.PSSaveButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.PSSaveButton.Location = new System.Drawing.Point(6, 341);
            this.PSSaveButton.Name = "PSSaveButton";
            this.PSSaveButton.Size = new System.Drawing.Size(82, 47);
            this.PSSaveButton.TabIndex = 12;
            this.PSSaveButton.Text = "Save";
            this.PSSaveButton.UseVisualStyleBackColor = false;
            this.PSSaveButton.Click += new System.EventHandler(this.PSSaveButton_Click);
            // 
            // PaymentScheduleTable
            // 
            this.PaymentScheduleTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentScheduleTable.AutoGenerateColumns = false;
            this.PaymentScheduleTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PaymentScheduleTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.PaymentScheduleTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.PaymentScheduleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentScheduleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.creditIdDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn1,
            this.interestRateDataGridViewTextBoxColumn,
            this.isPaidDataGridViewCheckBoxColumn});
            this.PaymentScheduleTable.DataSource = this.paymentScheduleBindingSource;
            this.PaymentScheduleTable.GridColor = System.Drawing.SystemColors.MenuText;
            this.PaymentScheduleTable.Location = new System.Drawing.Point(6, 6);
            this.PaymentScheduleTable.Name = "PaymentScheduleTable";
            this.PaymentScheduleTable.RowHeadersWidth = 51;
            this.PaymentScheduleTable.RowTemplate.Height = 24;
            this.PaymentScheduleTable.Size = new System.Drawing.Size(756, 329);
            this.PaymentScheduleTable.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.PercentReporpTable);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Percent report";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // PercentReporpTable
            // 
            this.PercentReporpTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PercentReporpTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PercentReporpTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.PercentReporpTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.PercentReporpTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PercentReporpTable.GridColor = System.Drawing.SystemColors.MenuText;
            this.PercentReporpTable.Location = new System.Drawing.Point(6, 6);
            this.PercentReporpTable.Name = "PercentReporpTable";
            this.PercentReporpTable.RowHeadersWidth = 51;
            this.PercentReporpTable.RowTemplate.Height = 24;
            this.PercentReporpTable.Size = new System.Drawing.Size(756, 385);
            this.PercentReporpTable.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.CreditsRefreshButton);
            this.tabPage2.Controls.Add(this.CreditsSaveButton);
            this.tabPage2.Controls.Add(this.CreditsTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Credits";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.Location = new System.Drawing.Point(94, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CreditsDeleteButton_Click);
            // 
            // CreditsRefreshButton
            // 
            this.CreditsRefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreditsRefreshButton.AutoSize = true;
            this.CreditsRefreshButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.CreditsRefreshButton.Location = new System.Drawing.Point(181, 336);
            this.CreditsRefreshButton.Name = "CreditsRefreshButton";
            this.CreditsRefreshButton.Size = new System.Drawing.Size(94, 47);
            this.CreditsRefreshButton.TabIndex = 8;
            this.CreditsRefreshButton.Text = "Refresh data";
            this.CreditsRefreshButton.UseVisualStyleBackColor = false;
            this.CreditsRefreshButton.Click += new System.EventHandler(this.CreditsRefreshButton_Click);
            // 
            // CreditsSaveButton
            // 
            this.CreditsSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreditsSaveButton.AutoSize = true;
            this.CreditsSaveButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.CreditsSaveButton.Location = new System.Drawing.Point(6, 336);
            this.CreditsSaveButton.Name = "CreditsSaveButton";
            this.CreditsSaveButton.Size = new System.Drawing.Size(82, 47);
            this.CreditsSaveButton.TabIndex = 7;
            this.CreditsSaveButton.Text = "Save";
            this.CreditsSaveButton.UseVisualStyleBackColor = false;
            this.CreditsSaveButton.Click += new System.EventHandler(this.CreditsSaveButton_Click);
            // 
            // CreditsTable
            // 
            this.CreditsTable.AllowUserToOrderColumns = true;
            this.CreditsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditsTable.AutoGenerateColumns = false;
            this.CreditsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CreditsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CreditsTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.CreditsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CreditsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.clientIdDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.annualInterestRateDataGridViewTextBoxColumn,
            this.pledgeDataGridViewTextBoxColumn});
            this.CreditsTable.DataSource = this.creditsBindingSource;
            this.CreditsTable.Location = new System.Drawing.Point(6, 6);
            this.CreditsTable.Name = "CreditsTable";
            this.CreditsTable.RowHeadersWidth = 51;
            this.CreditsTable.RowTemplate.Height = 24;
            this.CreditsTable.Size = new System.Drawing.Size(756, 324);
            this.CreditsTable.TabIndex = 0;
            this.CreditsTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CreditsValidation);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DebtTable);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 397);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Debts report";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DebtTable
            // 
            this.DebtTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebtTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DebtTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DebtTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DebtTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DebtTable.GridColor = System.Drawing.SystemColors.MenuText;
            this.DebtTable.Location = new System.Drawing.Point(6, 6);
            this.DebtTable.Name = "DebtTable";
            this.DebtTable.RowHeadersWidth = 51;
            this.DebtTable.RowTemplate.Height = 24;
            this.DebtTable.Size = new System.Drawing.Size(756, 385);
            this.DebtTable.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(564, 12);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.ShowOPReportButton);
            this.tabPage6.Controls.Add(this.monthCalendar1);
            this.tabPage6.Controls.Add(this.OverpaymentTable);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(768, 397);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Overpayment report";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // ShowOPReportButton
            // 
            this.ShowOPReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowOPReportButton.AutoSize = true;
            this.ShowOPReportButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ShowOPReportButton.Location = new System.Drawing.Point(617, 231);
            this.ShowOPReportButton.Name = "ShowOPReportButton";
            this.ShowOPReportButton.Size = new System.Drawing.Size(88, 47);
            this.ShowOPReportButton.TabIndex = 5;
            this.ShowOPReportButton.Text = "Show report";
            this.ShowOPReportButton.UseVisualStyleBackColor = false;
            this.ShowOPReportButton.Click += new System.EventHandler(this.ShowOPReportButton_Click);
            // 
            // OverpaymentTable
            // 
            this.OverpaymentTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverpaymentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OverpaymentTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.OverpaymentTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.OverpaymentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OverpaymentTable.GridColor = System.Drawing.SystemColors.MenuText;
            this.OverpaymentTable.Location = new System.Drawing.Point(6, 6);
            this.OverpaymentTable.Name = "OverpaymentTable";
            this.OverpaymentTable.RowHeadersWidth = 51;
            this.OverpaymentTable.RowTemplate.Height = 24;
            this.OverpaymentTable.Size = new System.Drawing.Size(541, 385);
            this.OverpaymentTable.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // taxCodeDataGridViewTextBoxColumn
            // 
            this.taxCodeDataGridViewTextBoxColumn.DataPropertyName = "TaxCode";
            this.taxCodeDataGridViewTextBoxColumn.HeaderText = "TaxCode";
            this.taxCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taxCodeDataGridViewTextBoxColumn.Name = "taxCodeDataGridViewTextBoxColumn";
            // 
            // legalAddressDataGridViewTextBoxColumn
            // 
            this.legalAddressDataGridViewTextBoxColumn.DataPropertyName = "LegalAddress";
            this.legalAddressDataGridViewTextBoxColumn.HeaderText = "LegalAddress";
            this.legalAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.legalAddressDataGridViewTextBoxColumn.Name = "legalAddressDataGridViewTextBoxColumn";
            // 
            // actualAddressDataGridViewTextBoxColumn
            // 
            this.actualAddressDataGridViewTextBoxColumn.DataPropertyName = "ActualAddress";
            this.actualAddressDataGridViewTextBoxColumn.HeaderText = "ActualAddress";
            this.actualAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actualAddressDataGridViewTextBoxColumn.Name = "actualAddressDataGridViewTextBoxColumn";
            // 
            // chiefInitialsDataGridViewTextBoxColumn
            // 
            this.chiefInitialsDataGridViewTextBoxColumn.DataPropertyName = "ChiefInitials";
            this.chiefInitialsDataGridViewTextBoxColumn.HeaderText = "ChiefInitials";
            this.chiefInitialsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chiefInitialsDataGridViewTextBoxColumn.Name = "chiefInitialsDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(Credit.Models.Clients);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // annualInterestRateDataGridViewTextBoxColumn
            // 
            this.annualInterestRateDataGridViewTextBoxColumn.DataPropertyName = "AnnualInterestRate";
            this.annualInterestRateDataGridViewTextBoxColumn.HeaderText = "AnnualInterestRate";
            this.annualInterestRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.annualInterestRateDataGridViewTextBoxColumn.Name = "annualInterestRateDataGridViewTextBoxColumn";
            // 
            // pledgeDataGridViewTextBoxColumn
            // 
            this.pledgeDataGridViewTextBoxColumn.DataPropertyName = "Pledge";
            this.pledgeDataGridViewTextBoxColumn.HeaderText = "Pledge";
            this.pledgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pledgeDataGridViewTextBoxColumn.Name = "pledgeDataGridViewTextBoxColumn";
            // 
            // creditsBindingSource
            // 
            this.creditsBindingSource.DataSource = typeof(Credit.Models.Credits);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // creditIdDataGridViewTextBoxColumn
            // 
            this.creditIdDataGridViewTextBoxColumn.DataPropertyName = "CreditId";
            this.creditIdDataGridViewTextBoxColumn.HeaderText = "CreditId";
            this.creditIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditIdDataGridViewTextBoxColumn.Name = "creditIdDataGridViewTextBoxColumn";
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            // 
            // interestRateDataGridViewTextBoxColumn
            // 
            this.interestRateDataGridViewTextBoxColumn.DataPropertyName = "InterestRate";
            this.interestRateDataGridViewTextBoxColumn.HeaderText = "InterestRate";
            this.interestRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.interestRateDataGridViewTextBoxColumn.Name = "interestRateDataGridViewTextBoxColumn";
            // 
            // isPaidDataGridViewCheckBoxColumn
            // 
            this.isPaidDataGridViewCheckBoxColumn.DataPropertyName = "IsPaid";
            this.isPaidDataGridViewCheckBoxColumn.HeaderText = "IsPaid";
            this.isPaidDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isPaidDataGridViewCheckBoxColumn.Name = "isPaidDataGridViewCheckBoxColumn";
            // 
            // paymentScheduleBindingSource
            // 
            this.paymentScheduleBindingSource.DataSource = typeof(Credit.Models.PaymentSchedule);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CreditApp";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsTable)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentScheduleTable)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PercentReporpTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreditsTable)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DebtTable)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OverpaymentTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentScheduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button ClientsDeleteButton;
        private System.Windows.Forms.Button ClientsOrderButton;
        private System.Windows.Forms.Button ClientsRatingButton;
        private System.Windows.Forms.Button ClientsRefreshButton;
        private System.Windows.Forms.Button ClientsSaveButton;
        private System.Windows.Forms.DataGridView ClientsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn legalAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiefInitialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button PSUpdateButton;
        private System.Windows.Forms.Button PSDeleteButton;
        private System.Windows.Forms.Button PSRefreshButton;
        private System.Windows.Forms.Button PSSaveButton;
        private System.Windows.Forms.DataGridView PaymentScheduleTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource paymentScheduleBindingSource;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView PercentReporpTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CreditsRefreshButton;
        private System.Windows.Forms.Button CreditsSaveButton;
        private System.Windows.Forms.DataGridView CreditsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualInterestRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pledgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource creditsBindingSource;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView DebtTable;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button ShowOPReportButton;
        private System.Windows.Forms.DataGridView OverpaymentTable;
        private System.Windows.Forms.TabControl tabControl1;
    }
}


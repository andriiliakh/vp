namespace Lab2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownXFrom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXTo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.numericUpDownDots = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonLoadPoints1 = new System.Windows.Forms.Button();
            this.buttonSavePoints1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonLoad2 = new System.Windows.Forms.Button();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.dataGridViewT = new System.Windows.Forms.DataGridView();
            this.ColumnT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDrawT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownTFrom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTDots = new System.Windows.Forms.NumericUpDown();
            this.textBoxMaxTY = new System.Windows.Forms.TextBox();
            this.numericUpDownTTo = new System.Windows.Forms.NumericUpDown();
            this.textBoxMinTY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTDots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTTo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            this.dataGridView.Location = new System.Drawing.Point(20, 6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(365, 233);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.ReadOnly = true;
            // 
            // numericUpDownXFrom
            // 
            this.numericUpDownXFrom.Location = new System.Drawing.Point(71, 295);
            this.numericUpDownXFrom.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownXFrom.Name = "numericUpDownXFrom";
            this.numericUpDownXFrom.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownXFrom.TabIndex = 1;
            // 
            // numericUpDownXTo
            // 
            this.numericUpDownXTo.Location = new System.Drawing.Point(71, 321);
            this.numericUpDownXTo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownXTo.Name = "numericUpDownXTo";
            this.numericUpDownXTo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownXTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "x from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "x to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dots";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "max";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(71, 400);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMin.TabIndex = 12;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(71, 432);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax.TabIndex = 13;
            // 
            // numericUpDownDots
            // 
            this.numericUpDownDots.Location = new System.Drawing.Point(71, 363);
            this.numericUpDownDots.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDots.Name = "numericUpDownDots";
            this.numericUpDownDots.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDots.TabIndex = 14;
            this.numericUpDownDots.ValueChanged += new System.EventHandler(this.numericUpDownDots_ValueChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(391, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(557, 468);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(227, 432);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 16;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1513, 509);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonLoadPoints1);
            this.tabPage1.Controls.Add(this.buttonSavePoints1);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.buttonDraw);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDownXFrom);
            this.tabPage1.Controls.Add(this.numericUpDownDots);
            this.tabPage1.Controls.Add(this.textBoxMax);
            this.tabPage1.Controls.Add(this.numericUpDownXTo);
            this.tabPage1.Controls.Add(this.textBoxMin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1505, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonLoadPoints1
            // 
            this.buttonLoadPoints1.Location = new System.Drawing.Point(214, 325);
            this.buttonLoadPoints1.Name = "buttonLoadPoints1";
            this.buttonLoadPoints1.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadPoints1.TabIndex = 18;
            this.buttonLoadPoints1.Text = "LoadPoints";
            this.buttonLoadPoints1.UseVisualStyleBackColor = true;
            this.buttonLoadPoints1.Click += new System.EventHandler(this.buttonLoadPoints1_Click);
            // 
            // buttonSavePoints1
            // 
            this.buttonSavePoints1.Location = new System.Drawing.Point(214, 295);
            this.buttonSavePoints1.Name = "buttonSavePoints1";
            this.buttonSavePoints1.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePoints1.TabIndex = 17;
            this.buttonSavePoints1.Text = "Save Points";
            this.buttonSavePoints1.UseVisualStyleBackColor = true;
            this.buttonSavePoints1.Click += new System.EventHandler(this.buttonSavePoints1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart3);
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Controls.Add(this.buttonLoad2);
            this.tabPage2.Controls.Add(this.buttonSave2);
            this.tabPage2.Controls.Add(this.dataGridViewT);
            this.tabPage2.Controls.Add(this.buttonDrawT);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.numericUpDownTFrom);
            this.tabPage2.Controls.Add(this.numericUpDownTDots);
            this.tabPage2.Controls.Add(this.textBoxMaxTY);
            this.tabPage2.Controls.Add(this.numericUpDownTTo);
            this.tabPage2.Controls.Add(this.textBoxMinTY);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1505, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // chart3
            // 
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(946, 3);
            this.chart3.Name = "chart3";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "X(t)";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Y(t)";
            this.chart3.Series.Add(series2);
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(578, 471);
            this.chart3.TabIndex = 31;
            this.chart3.Text = "chart3";
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(384, 6);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "X(Y)";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Y(X)";
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(578, 471);
            this.chart2.TabIndex = 30;
            this.chart2.Text = "chart2";
            // 
            // buttonLoad2
            // 
            this.buttonLoad2.Location = new System.Drawing.Point(212, 332);
            this.buttonLoad2.Name = "buttonLoad2";
            this.buttonLoad2.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad2.TabIndex = 33;
            this.buttonLoad2.Text = "LoadPoints";
            this.buttonLoad2.UseVisualStyleBackColor = true;
            this.buttonLoad2.Click += new System.EventHandler(this.buttonLoad2_Click);
            // 
            // buttonSave2
            // 
            this.buttonSave2.Location = new System.Drawing.Point(212, 302);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(75, 23);
            this.buttonSave2.TabIndex = 32;
            this.buttonSave2.Text = "Save Points";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.buttonSave2_Click);
            // 
            // dataGridViewT
            // 
            this.dataGridViewT.AllowUserToAddRows = false;
            this.dataGridViewT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnT,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewT.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewT.Name = "dataGridViewT";
            this.dataGridViewT.ShowEditingIcon = false;
            this.dataGridViewT.Size = new System.Drawing.Size(372, 271);
            this.dataGridViewT.TabIndex = 19;
            // 
            // ColumnT
            // 
            this.ColumnT.HeaderText = "T";
            this.ColumnT.Name = "ColumnT";
            this.ColumnT.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Y";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // buttonDrawT
            // 
            this.buttonDrawT.Location = new System.Drawing.Point(225, 439);
            this.buttonDrawT.Name = "buttonDrawT";
            this.buttonDrawT.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawT.TabIndex = 31;
            this.buttonDrawT.Text = "Draw";
            this.buttonDrawT.UseVisualStyleBackColor = true;
            this.buttonDrawT.Click += new System.EventHandler(this.buttonDrawT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "t from";
            // 
            // numericUpDownTFrom
            // 
            this.numericUpDownTFrom.Location = new System.Drawing.Point(69, 302);
            this.numericUpDownTFrom.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownTFrom.Name = "numericUpDownTFrom";
            this.numericUpDownTFrom.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTFrom.TabIndex = 20;
            // 
            // numericUpDownTDots
            // 
            this.numericUpDownTDots.Location = new System.Drawing.Point(69, 370);
            this.numericUpDownTDots.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTDots.Name = "numericUpDownTDots";
            this.numericUpDownTDots.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTDots.TabIndex = 29;
            // 
            // textBoxMaxTY
            // 
            this.textBoxMaxTY.Location = new System.Drawing.Point(69, 439);
            this.textBoxMaxTY.Name = "textBoxMaxTY";
            this.textBoxMaxTY.ReadOnly = true;
            this.textBoxMaxTY.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxTY.TabIndex = 28;
            // 
            // numericUpDownTTo
            // 
            this.numericUpDownTTo.Location = new System.Drawing.Point(69, 328);
            this.numericUpDownTTo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownTTo.Name = "numericUpDownTTo";
            this.numericUpDownTTo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTTo.TabIndex = 21;
            // 
            // textBoxMinTY
            // 
            this.textBoxMinTY.Location = new System.Drawing.Point(69, 407);
            this.textBoxMinTY.Name = "textBoxMinTY";
            this.textBoxMinTY.ReadOnly = true;
            this.textBoxMinTY.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinTY.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "t to";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Dots";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 690);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTDots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.NumericUpDown numericUpDownXFrom;
        private System.Windows.Forms.NumericUpDown numericUpDownXTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.NumericUpDown numericUpDownDots;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSavePoints1;
        private System.Windows.Forms.Button buttonLoadPoints1;
        private System.Windows.Forms.Button buttonLoad2;
        private System.Windows.Forms.Button buttonSave2;
        private System.Windows.Forms.DataGridView dataGridViewT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button buttonDrawT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTFrom;
        private System.Windows.Forms.NumericUpDown numericUpDownTDots;
        private System.Windows.Forms.TextBox textBoxMaxTY;
        private System.Windows.Forms.NumericUpDown numericUpDownTTo;
        private System.Windows.Forms.TextBox textBoxMinTY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}


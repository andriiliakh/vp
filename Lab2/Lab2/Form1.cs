using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ElementPosition elementPositionY = new ElementPosition(1, 2, 6, 6);
            Title Y = new Title("Y", Docking.Top);
            Y.Position = elementPositionY;
            chart1.Titles.Add(Y);
            ElementPosition elementPositionX = new ElementPosition(90, 90, 6, 6);
            Title X = new Title("X", Docking.Top);
            X.Position = elementPositionX;
            chart1.Titles.Add(X);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            int dots = Convert.ToInt32(numericUpDownDots.Value);
            decimal end = numericUpDownXTo.Value;
            decimal start = numericUpDownXFrom.Value;
            double diff = (double)(Math.Abs(start - end) / (dots - 1));
            chart1.Series["Series1"].Points.Clear();
            double x = Convert.ToDouble(start);
            double y;
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            for (int i = 0; i < dots; i++)
            {
                if (i == dots - 1)
                {
                    x = Convert.ToDouble(end);
                }
                y = Math.Exp(-2 * x) * Math.Sin(x * Math.PI / 180.0) * Math.Sin(x * Math.PI / 180.0);
                chart1.Series["Series1"].Points.AddXY(x, y);
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = x;
                dataGridView.Rows[i].Cells[1].Value = y;
                x += diff;
            }
            textBoxMin.Text = chart1.Series["Series1"].Points.FindMinByValue().YValues[0].ToString();
            textBoxMax.Text = chart1.Series["Series1"].Points.FindMaxByValue().YValues[0].ToString();
            dataGridView.Refresh();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSavePoints1_Click(object sender, EventArgs e)
        {
            string file = "C:\\vpsaves\\XY.bin";
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(Convert.ToDouble(numericUpDownDots.Value));
                bw.Write(Convert.ToDouble(numericUpDownXFrom.Value));
                bw.Write(Convert.ToDouble(numericUpDownXTo.Value));
                bw.Write(dataGridView.Columns.Count);
                bw.Write(dataGridView.Rows.Count);
                foreach (DataGridViewRow dgvR in dataGridView.Rows)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
            }
        }

        private void buttonLoadPoints1_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            chart1.Series["Series1"].Points.Clear();
            string file = "C:\\vpsaves\\XY.bin";
            using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                numericUpDownDots.Value = Convert.ToDecimal(bw.ReadDouble());
                numericUpDownXFrom.Value = Convert.ToDecimal(bw.ReadDouble());
                numericUpDownXTo.Value = Convert.ToDecimal(bw.ReadDouble());
                int n = bw.ReadInt32();
                int m = bw.ReadInt32();
                for (int i = 0; i < m; i++)
                {
                    dataGridView.Rows.Add();
                    for (int j = 0; j < n; ++j)
                    {
                        if (bw.ReadBoolean())
                        {
                            dataGridView.Rows[i].Cells[j].Value = bw.ReadString();
                        }
                        else bw.ReadBoolean();
                    }
                    chart1.Series["Series1"].Points.AddXY(Convert.ToDouble(dataGridView.Rows[i].Cells[0].Value), Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value));
                }
            }
            textBoxMin.Text = chart1.Series["Series1"].Points.FindMinByValue().YValues[0].ToString();
            textBoxMax.Text = chart1.Series["Series1"].Points.FindMaxByValue().YValues[0].ToString();
            dataGridView.Refresh();
        }

        private void buttonDrawT_Click(object sender, EventArgs e)
        {
            int dots = Convert.ToInt32(numericUpDownTDots.Value);
            decimal end = numericUpDownTTo.Value;
            decimal start = numericUpDownTFrom.Value;
            double diff = (double)(Math.Abs(start - end) / (dots - 1));
            chart2.Series["Y(X)"].Points.Clear();
            chart2.Series["X(Y)"].Points.Clear();
            chart3.Series["X(t)"].Points.Clear();
            chart3.Series["Y(t)"].Points.Clear();
            double t = Convert.ToDouble(start);
            double x, y;
            dataGridViewT.DataSource = null;
            dataGridViewT.Rows.Clear();
            dataGridViewT.Refresh();
            for (int i = 0; i < dots; i++)
            {
                if (i == dots - 1)
                    t = Convert.ToDouble(end);

                x = t > 0 ? Math.Pow(t, 1.0 / 3.0) : -1.0 * Math.Pow(-1.0 * t, 1.0 / 3.0);
                y = (1.0 - t) > 0 ? Math.Pow(1.0 - t, 1.0 / 3.0) : -1.0 * Math.Pow(-1.0 * (1.0 - t), 1.0 / 3.0);
                chart2.Series["Y(X)"].Points.AddXY(x, y);
                chart2.Series["X(Y)"].Points.AddXY(y, x);
                chart3.Series["X(t)"].Points.AddXY(t, x);
                chart3.Series["Y(t)"].Points.AddXY(t, y);

                dataGridViewT.Rows.Add();
                dataGridViewT.Rows[i].Cells[0].Value = chart3.Series["X(t)"].Points[i].XValue;
                dataGridViewT.Rows[i].Cells[1].Value = chart2.Series["Y(X)"].Points[i].XValue;
                dataGridViewT.Rows[i].Cells[2].Value = chart2.Series["Y(X)"].Points[i].YValues[0];

                t += diff;
            }
            textBoxMinTY.Text = chart2.Series["Y(X)"].Points.FindMinByValue().YValues[0].ToString();
            textBoxMaxTY.Text = chart2.Series["Y(X)"].Points.FindMaxByValue().YValues[0].ToString();
            dataGridViewT.Refresh();
        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            string file = "C:\\vpsaves\\TXY.bin";
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(Convert.ToDouble(numericUpDownTDots.Value));
                bw.Write(Convert.ToDouble(numericUpDownTFrom.Value));
                bw.Write(Convert.ToDouble(numericUpDownTTo.Value));
                bw.Write(dataGridViewT.Columns.Count);
                bw.Write(dataGridViewT.Rows.Count);
                foreach (DataGridViewRow dgvR in dataGridViewT.Rows)
                {
                    for (int j = 0; j < dataGridViewT.Columns.Count; j++)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
            }
        }

        private void buttonLoad2_Click(object sender, EventArgs e)
        {
            dataGridViewT.Rows.Clear();
            chart2.Series["Y(X)"].Points.Clear();
            chart2.Series["X(Y)"].Points.Clear();
            chart3.Series["X(t)"].Points.Clear();
            chart3.Series["Y(t)"].Points.Clear();
            double t, x, y;
            string file = "C:\\vpsaves\\TXY.bin";
            using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                numericUpDownTDots.Value = Convert.ToDecimal(bw.ReadDouble());
                numericUpDownTFrom.Value = Convert.ToDecimal(bw.ReadDouble());
                numericUpDownTTo.Value = Convert.ToDecimal(bw.ReadDouble());
                int n = bw.ReadInt32();
                int m = bw.ReadInt32();
                for (int i = 0; i < m; i++)
                {
                    dataGridViewT.Rows.Add();
                    for (int j = 0; j < n; ++j)
                    {
                        if (bw.ReadBoolean())
                        {
                            dataGridViewT.Rows[i].Cells[j].Value = bw.ReadString();
                        }
                        else bw.ReadBoolean();
                    }
                    t = Convert.ToDouble(dataGridViewT.Rows[i].Cells[0].Value);
                    x = Convert.ToDouble(dataGridViewT.Rows[i].Cells[1].Value);
                    y = Convert.ToDouble(dataGridViewT.Rows[i].Cells[2].Value);
                    chart2.Series["Y(X)"].Points.AddXY(x, y);
                    chart2.Series["X(Y)"].Points.AddXY(y, x);
                    chart3.Series["X(t)"].Points.AddXY(t, x);
                    chart3.Series["Y(t)"].Points.AddXY(t, y);
                }
            }
            textBoxMinTY.Text = chart2.Series["Y(X)"].Points.FindMinByValue().YValues[0].ToString();
            textBoxMaxTY.Text = chart2.Series["Y(X)"].Points.FindMaxByValue().YValues[0].ToString();
        }

        private void numericUpDownDots_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

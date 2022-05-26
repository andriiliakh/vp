using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {

        String filepath;
        List<Worker> workers;

        public Form1()
        {
            workers = new List<Worker>();
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            workers = new List<Worker>();
            filepath = null;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            workers = new List<Worker>();

            List<Worker> tempWorkers = new List<Worker>();
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Binary file|*.bin|Text file|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string extesion = Path.GetExtension(fileName);
                filepath = Path.GetFullPath(fileName);
                switch (extesion)
                {
                    case ".txt":
                        string[] lines = File.ReadAllLines(filepath);
                        foreach (string line in lines)
                        {
                            tempWorkers.Add(new Worker(line));
                        }
                        break;
                    case ".bin":
                        using (var stream = File.Open(fileName, FileMode.Open))
                        {
                            using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                            {
                                int count = reader.ReadInt32();
                                for (int i = 0; i < count; i++)
                                {
                                    string input = reader.ReadString();
                                    tempWorkers.Add(new Worker(input));
                                }
                            }
                        }
                        break;
                    default:
                        DialogResult resultBin = MessageBox.Show("Incorrect extension!", "ERROR!", MessageBoxButtons.OK);
                        if (resultBin == DialogResult.OK)
                        {
                            this.Close();
                        }
                        break;
                }
                workers.AddRange(tempWorkers);
                updateData();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Binary file|*.bin|Text file|*.txt";
            saveFileDialog1.Title = "Save a File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                string extesion = Path.GetExtension(fileName);
                string path = Path.GetFullPath(fileName);
                switch (extesion)
                {
                    case ".txt":
                        using (StreamWriter writer = File.CreateText(path))
                        {
                            foreach (Worker w in workers)
                            {
                                writer.Write(w.ToString() + '\n');
                            }
                        }
                        break;
                    case ".bin":
                        using (var stream = File.Open(fileName, FileMode.Create))
                        {
                            using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                            {
                                writer.Write((Int32)workers.Count);
                                for (int i = 0; i < workers.Count; i++)
                                {
                                    writer.Write(workers[i].ToString());
                                }
                            }
                        }
                        break;
                    default:
                        DialogResult result = MessageBox.Show("Incorrect extension!", "ERROR!", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            this.Close();
                        }
                        break;
                }
            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            workers = new List<Worker>();

            List<Worker> tempWorkers = new List<Worker>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string temp = "";
                for (int i = 0; i < row.Cells.Count; i++)
                {

                    if (row.Cells[i].Value == null)
                    {
                        temp += "|";
                    }
                    else
                    {
                        temp += row.Cells[i].Value.ToString() + "|";
                    }
                }
                temp = temp.Substring(0, temp.Length - 1);
                tempWorkers.Add(new Worker(temp));
            }

            workers.AddRange(tempWorkers);
        }

        private void updateData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            int i = 0;
            foreach(Worker w in workers)
            {
                if (w.isEmpty()) { continue; }
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = w.surname;
                dataGridView1.Rows[i].Cells[1].Value = w.name;
                if (w.dateBirth.Year < 1900)
                {
                    dataGridView1.Rows[i].Cells[2].Value = "";
                } else
                {
                    dataGridView1.Rows[i].Cells[2].Value = w.dateBirth.ToString("dd/MM/yyyy");
                }
                dataGridView1.Rows[i].Cells[3].Value = w.number;
                dataGridView1.Rows[i].Cells[4].Value = w.country;
                dataGridView1.Rows[i].Cells[5].Value = w.city;
                dataGridView1.Rows[i].Cells[6].Value = w.street;
                dataGridView1.Rows[i].Cells[7].Value = w.building;
                dataGridView1.Rows[i].Cells[8].Value = w.flat;
                i++;
            }
            dataGridView1.Refresh();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            string street = textBoxStreet.Text;
            string building = textBoxBuilding.Text;
            string flat = textBoxFlat.Text;
            List<Worker> filteredWorkers = workers.FindAll(w => (w.street == street && w.building == building && w.flat == flat));
            if (filteredWorkers.Count > 0)
            {
                labelWarning.Text = "Found " + filteredWorkers.Count + " match(-es).";
                int i = 0;
                foreach (Worker w in filteredWorkers)
                {
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].Cells[0].Value = w.surname;
                    dataGridView2.Rows[i].Cells[1].Value = w.name;
                    dataGridView2.Rows[i].Cells[2].Value = w.number;
                    i++;
                }
                labelAge.Text = "Average age of filtered workers is " + filteredWorkers.Average(w =>
                {
                    var age = DateTime.Now.Year - w.dateBirth.Year;
                    if (w.dateBirth.Date > DateTime.Now.AddYears(-age)) age--;
                    Console.WriteLine(age);
                    return age;
                });
            } else
            {
                labelAge.Text = "";
                labelWarning.Text = "Nothing found!";
            }
            dataGridView2.Refresh();
        }
    }
}

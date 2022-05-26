using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Lab5
{
    public partial class Form1 : Form
    {

        String filepath;
        List<Student> students;

        public Form1()
        {
            students = new List<Student>();
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            students = new List<Student>();
            filepath = null;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            students = new List<Student>();

            List<Student> tempStudents = new List<Student>();
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "XML file|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                filepath = Path.GetFullPath(fileName);

                var path = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
                XmlSchemaSet schema = new XmlSchemaSet();
                schema.Add("", "D:\\виключение\\Політех\\Візуалка\\Lab5\\Lab3\\try1.xsd");
                XmlReader rd = XmlReader.Create(filepath);
                XDocument doc1 = XDocument.Load(rd);
                doc1.Validate(schema, null);

                XmlReader doc = XmlReader.Create(filepath);
                doc.Read(); //read xml node 
                doc.Read(); //read students node
                int count = Int32.Parse(doc.GetAttribute("number"));

                for (int i = 0; i < count; i++)
                {
                    doc.Read();
                    if (doc.Name == "student")
                    {
                        tempStudents.Add(new Student(
                            doc.GetAttribute("surname"),
                            doc.GetAttribute("name"),
                            doc.GetAttribute("city"),
                            Int32.Parse(doc.GetAttribute("ukr")),
                            Int32.Parse(doc.GetAttribute("math")),
                            Int32.Parse(doc.GetAttribute("eng"))
                            ));
                    }
                }
                doc.Close();

                students.AddRange(tempStudents);
                updateData();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML file|*.xml";
            saveFileDialog1.Title = "Save a File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                filepath = Path.GetFullPath(fileName);

                XmlWriter xmlWriter = XmlWriter.Create(filepath);

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("students");
                xmlWriter.WriteAttributeString("number", "" + students.Count);

                foreach (Student s in students)
                {
                    xmlWriter.WriteStartElement("student");
                    xmlWriter.WriteAttributeString("surname", s.surname);
                    xmlWriter.WriteAttributeString("name", s.name);
                    xmlWriter.WriteAttributeString("city", s.city);
                    xmlWriter.WriteAttributeString("ukr", "" + s.ukr);
                    xmlWriter.WriteAttributeString("math", "" + s.math);
                    xmlWriter.WriteAttributeString("eng", "" + s.eng);
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            students = new List<Student>();

            List<Student> tempStudents = new List<Student>();

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
                tempStudents.Add(new Student(temp));
            }

            students.AddRange(tempStudents);
        }

        private void updateData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            int i = 0;
            foreach (Student s in students)
            {
                if (s.isEmpty()) { continue; }
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = s.surname;
                dataGridView1.Rows[i].Cells[1].Value = s.name;
                dataGridView1.Rows[i].Cells[2].Value = s.city;
                dataGridView1.Rows[i].Cells[3].Value = s.ukr;
                dataGridView1.Rows[i].Cells[4].Value = s.math;
                dataGridView1.Rows[i].Cells[5].Value = s.eng;
                i++;
            }
            dataGridView1.Refresh();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            string city = textBoxCity.Text;
            double avg = double.Parse(textBoxMinAvg.Text.Replace(".",","));
            List<Student> filteredStudents = students.FindAll(s => (s.city.Equals(city) && s.avg()>=avg));
            if (filteredStudents.Count > 0)
            {
                labelWarning.Text = "Found " + filteredStudents.Count + " match(-es).";
                int i = 0;
                foreach (Student s in filteredStudents)
                {
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].Cells[0].Value = s.surname;
                    dataGridView2.Rows[i].Cells[1].Value = s.name;
                    dataGridView2.Rows[i].Cells[2].Value = s.avg();
                    i++;
                }
            }
            else
            {
                labelWarning.Text = "None found!";
            }
            dataGridView2.Refresh();
        }
    }
}

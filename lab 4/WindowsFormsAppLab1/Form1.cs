using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsAppLab1
{
    public partial class Form1 : Form
    {
        private TextBox textBoxFocuced;
        public Form1()
        {
            InitializeComponent();
            textBoxFocuced = textBoxSquareA;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("state.xml");
                radioButtonSquare.Checked = doc.DocumentElement.SelectSingleNode("/last_program_state/radioButtonSquare").InnerText.Equals("True");
                radioButtonRect.Checked = doc.DocumentElement.SelectSingleNode("/last_program_state/radioButtonRect").InnerText.Equals("True");
                radioButtonPar.Checked = doc.DocumentElement.SelectSingleNode("/last_program_state/radioButtonPar").InnerText.Equals("True");
                radioButtonRomb.Checked = doc.DocumentElement.SelectSingleNode("/last_program_state/radioButtonRomb").InnerText.Equals("True");
                radioButtonTrap.Checked = doc.DocumentElement.SelectSingleNode("/last_program_state/radioButtonTrap").InnerText.Equals("True");
                textBoxSquareA.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxSquareA").InnerText;
                textBoxRectA.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxRectA").InnerText;
                textBoxRectB.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxRectB").InnerText;
                textBoxParA.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxParA").InnerText;
                textBoxParB.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxParB").InnerText;
                textBoxParCor.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxParCor").InnerText;
                textBoxRombA.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxRombA").InnerText;
                textBoxRombH.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxRombH").InnerText;
                textBoxTrapA.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxTrapA").InnerText;
                textBoxTrapB.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxTrapB").InnerText;
                textBoxTrapC.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxTrapC").InnerText;
                textBoxTrapD.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxTrapD").InnerText;
                textBoxTrapH.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxTrapH").InnerText;
                checkBoxPerim.Checked = doc.DocumentElement.SelectSingleNode("/last_program_state/checkBoxPerim").InnerText.Equals("True");
                checkBoxArea.Checked = doc.DocumentElement.SelectSingleNode("/last_program_state/checkBoxArea").InnerText.Equals("True");
                textBoxResPerim.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxResPerim").InnerText;
                textBoxResArea.Text = doc.DocumentElement.SelectSingleNode("/last_program_state/textBoxResArea").InnerText;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlWriter xmlWriter = XmlWriter.Create("state.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("last_program_state");

            xmlWriter.WriteStartElement("radioButtonSquare");
            xmlWriter.WriteString(radioButtonSquare.Checked.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("radioButtonRect");
            xmlWriter.WriteString(radioButtonRect.Checked.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("radioButtonPar");
            xmlWriter.WriteString(radioButtonPar.Checked.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("radioButtonRomb");
            xmlWriter.WriteString(radioButtonRomb.Checked.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("radioButtonTrap");
            xmlWriter.WriteString(radioButtonTrap.Checked.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxSquareA");
            xmlWriter.WriteString(textBoxSquareA.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxRectA");
            xmlWriter.WriteString(textBoxRectA.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxRectB");
            xmlWriter.WriteString(textBoxRectB.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxParA");
            xmlWriter.WriteString(textBoxParA.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxParB");
            xmlWriter.WriteString(textBoxParB.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxParCor");
            xmlWriter.WriteString(textBoxParCor.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxRombA");
            xmlWriter.WriteString(textBoxRombA.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxRombH");
            xmlWriter.WriteString(textBoxRombH.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxTrapA");
            xmlWriter.WriteString(textBoxTrapA.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxTrapB");
            xmlWriter.WriteString(textBoxTrapB.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxTrapC");
            xmlWriter.WriteString(textBoxTrapC.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxTrapD");
            xmlWriter.WriteString(textBoxTrapD.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxTrapH");
            xmlWriter.WriteString(textBoxTrapH.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("checkBoxPerim");
            xmlWriter.WriteString(checkBoxPerim.Checked.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("checkBoxArea");
            xmlWriter.WriteString(checkBoxArea.Checked.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxResPerim");
            xmlWriter.WriteString(textBoxResPerim.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("textBoxResArea");
            xmlWriter.WriteString(textBoxResArea.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                Warning.Text = "Input only digits or dot";
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                Warning.Text = "Input only digits or dot";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxFocuced.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxFocuced.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxFocuced.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxFocuced.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxFocuced.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxFocuced.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxFocuced.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxFocuced.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxFocuced.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxFocuced.Text += "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBoxFocuced.Text += ".";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFocuced.Text += "";

            textBoxSquareA.Text = "";

            textBoxRectA.Text = "";
            textBoxRectB.Text = "";

            textBoxParA.Text = "";
            textBoxParB.Text = "";
            textBoxParCor.Text = "";

            textBoxRombA.Text = "";
            textBoxRombH.Text = "";

            textBoxTrapA.Text = "";
            textBoxTrapB.Text = "";
            textBoxTrapC.Text = "";
            textBoxTrapD.Text = "";
            textBoxTrapH.Text = "";

            textBoxResPerim.Text = "";
            textBoxResArea.Text = "";
            checkBoxPerim.Checked = false;
            checkBoxArea.Checked = false;

            radioButtonSquare.Checked = false;
            radioButtonRect.Checked = false;
            radioButtonPar.Checked = false;
            radioButtonRomb.Checked = false;
            radioButtonTrap.Checked = false;
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            if (checkBoxPerim.Checked)
            {
                try
                {
                    if (radioButtonSquare.Checked)
                    {
                        textBoxResPerim.Text = "" + (4.0 * Double.Parse(textBoxSquareA.Text));
                    }
                    if (radioButtonRect.Checked)
                    {
                        textBoxResPerim.Text = "" + (2.0 * (Double.Parse(textBoxRectA.Text) + Double.Parse(textBoxRectB.Text)));
                    }
                    if (radioButtonPar.Checked)
                    {
                        textBoxResPerim.Text = "" + (2.0 * (Double.Parse(textBoxParA.Text) + Double.Parse(textBoxParB.Text)));
                    }
                    if (radioButtonRomb.Checked)
                    {
                        textBoxResPerim.Text = "" + (4.0 * Double.Parse(textBoxRombA.Text));
                    }
                    if (radioButtonTrap.Checked)
                    {
                        textBoxResPerim.Text = "" + (Double.Parse(textBoxTrapA.Text) + Double.Parse(textBoxTrapB.Text)
                            + Double.Parse(textBoxTrapC.Text) + Double.Parse(textBoxTrapD.Text));
                    }
                } catch (Exception ex)
                {
                    Warning.Text = "No input data or incorrect input data";
                }
            }

            if (checkBoxArea.Checked)
            {
                try
                {
                    if (radioButtonSquare.Checked)
                    {
                        textBoxResArea.Text = "" + (Math.Pow(Double.Parse(textBoxSquareA.Text), 2));
                    }
                    if (radioButtonRect.Checked)
                    {
                        textBoxResArea.Text = "" + (Double.Parse(textBoxRectA.Text) * Double.Parse(textBoxRectB.Text));
                    }
                    if (radioButtonPar.Checked)
                    {
                        textBoxResArea.Text = "" + (Double.Parse(textBoxParA.Text) * Double.Parse(textBoxParB.Text) * Math.Sin(Double.Parse(textBoxParCor.Text) * Math.PI / 180.0));
                    }
                    if (radioButtonRomb.Checked)
                    {
                        textBoxResArea.Text = "" + (Double.Parse(textBoxRombA.Text) * Double.Parse(textBoxRombH.Text));
                    }
                    if (radioButtonTrap.Checked)
                    {
                        textBoxResArea.Text = "" + ((Double.Parse(textBoxTrapA.Text) + Double.Parse(textBoxTrapB.Text)) * Double.Parse(textBoxTrapH.Text) / 2.0);
                    }
                } catch (Exception ex)
                {
                    Warning.Text = "No input data or incorrect input data";
                }
            }
        }

        private void textBoxA_Enter(object sender, EventArgs e)
        {
            textBoxFocuced = (TextBox)sender;
        }

        private void checkBoxm_a_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxPerim.Checked)
                textBoxResPerim.Text = "";
        }

        private void checkBoxP_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxArea.Checked)
                textBoxResArea.Text = "";
        }


    }
}

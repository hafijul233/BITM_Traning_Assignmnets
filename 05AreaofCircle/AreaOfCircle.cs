using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05AreaofCircle
{
    public partial class AreaOfCircle : Form
    {
        public AreaOfCircle()
        {
            InitializeComponent();
        }

        private string programTitle = "Cirecle Wizard";

        private void inputRadiusTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = inputRadiusTextBox.Text;

            foreach (char c in temp)
            {
                if (Char.IsDigit(c) == false && c != '.')
                {
                    MessageBox.Show("Only Numbers are Allowed.", programTitle);
                    return;
                }
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string inputRadius = inputRadiusTextBox.Text;

            string replyMessage = String.Empty;

            if (inputRadius.Length == 0)
            {
                replyMessage = "Input Stream is Empty.";

            }

            else
            {
                double radius = Convert.ToDouble(inputRadiusTextBox.Text);

                double area = Math.PI * radius * radius;

                double perimeter = 2 * Math.PI * radius;

                double volume = 4 / 3.0 * Math.PI * (radius * radius * radius);

                replyMessage = "Circle Information\n" +
                               "\nCircle Radius: " + Math.Round(radius,6).ToString() +
                               "\nCircle Area : " + Math.Round(area,6).ToString() +
                               "\nCircle Perimeter : " + Math.Round(perimeter,6).ToString();
            }

            MessageBox.Show(replyMessage, programTitle);
        }

        private void AreaOfCircle_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure to Quit!", programTitle,
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {
                e.Cancel = true;
            }
        }
    }
}

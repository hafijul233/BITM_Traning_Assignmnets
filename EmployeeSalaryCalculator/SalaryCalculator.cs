using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06EmployeeSalaryCalculator
{
    public partial class SalaryCalculator : Form
    {
        public SalaryCalculator()
        {
            InitializeComponent();
        }

        private string _programTitle = "Salary Calculator";
        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = salaryTextBox.Text;

            foreach (char c in temp)
            {
                if (Char.IsDigit(c) == false && c != '.')
                {
                    MessageBox.Show("Only Numbers and (.) are Allowed.", _programTitle);
                    return;
                }
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string salary = salaryTextBox.Text;

            string replyMessage = String.Empty;

            if (salary.Length == 0)
            {
                replyMessage = "Input Stream is Empty.";

            }

            else
            {
                double empSalary = Convert.ToDouble(salaryTextBox.Text);
                double bonus = 0.0;
                int rate = 0;

                if (empSalary > 10000)
                {
                    bonus = (empSalary * 5) / 100;
                    rate = 5;
                }

                else if (empSalary <= 10000 && empSalary >= 8000)
                {
                    bonus = (empSalary * 6) / 100;
                    rate = 6;
                }

                else
                {
                    bonus = (empSalary * 7) / 100;
                    rate = 7;
                }

                replyMessage = "Salary Bonus Information\n" +
                               "\nEmployee Salary: " + empSalary.ToString() +
                               "\nBonus Rate : " + rate.ToString() +
                               "\nSalary Bonus : " + bonus.ToString();
            }

            MessageBox.Show(replyMessage, _programTitle);
        }

        private void SalaryCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure to Quit!", _programTitle,
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

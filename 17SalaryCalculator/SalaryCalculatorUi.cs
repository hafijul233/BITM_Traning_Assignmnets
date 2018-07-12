using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _03SalaryCalculator.Class;

namespace _03SalaryCalculator
{
    public partial class SalaryCalculatorUi : Form
    {
        EmployeeSalary Shirajul = new EmployeeSalary();

        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowSalaryButton_Click(object sender, EventArgs e)
        {
            if (EmpNameTextBox.Text == String.Empty ||
               BasicAmountTextBox.Text == String.Empty ||
               HouseRentTextBox.Text == String.Empty ||
               MedicalAllowTextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Field is Empty");
            }
            else
            {
                string empName = EmpNameTextBox.Text;
                string basicSalary = BasicAmountTextBox.Text;
                string houseRent = HouseRentTextBox.Text;
                string medicalAllow = MedicalAllowTextBox.Text;


                string message = Shirajul.GetNetSalary(empName, basicSalary, houseRent, medicalAllow);

                MessageBox.Show(message);
            }
        }
    }
}

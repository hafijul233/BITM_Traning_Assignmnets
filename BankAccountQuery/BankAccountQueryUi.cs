using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01BankAccountQuery.Class;


namespace _01BankAccountQuery
{
    public partial class BankAccountQueryUi : Form
    {
        public BankAccountQueryUi()
        {
            InitializeComponent();
        }

        AccountInfo Hafiz = new AccountInfo();

        private void AccountNoTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = AccountNoTextBox.Text;

            foreach(char c in temp){
                if(char.IsDigit(c) == false)
                {
                    MessageBox.Show("Only Numbers are Allowed.");
                }
            }
        }

        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = CustomerNameTextBox.Text;

            foreach (char c in temp){
                if (char.IsDigit(c) == true)
                {
                    MessageBox.Show("Numbers are Not Allowed.");
                }
            }

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string accountNumber = AccountNoTextBox.Text;
            string customerName = CustomerNameTextBox.Text;

            Hafiz.CreateAccount(accountNumber, customerName);

            MessageBox.Show("Account Created");
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = AccountNoTextBox.Text;

            foreach (char c in temp)
            {
                if (char.IsDigit(c) == false && c != '.')
                {
                    MessageBox.Show("Only Numbers and (.) are Allowed.");
                }
            }
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            string depositAmount = AmountTextBox.Text;

            Hafiz.DepositBalance(depositAmount);

            MessageBox.Show("Deposit Received");
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            string withdrawAmount = AmountTextBox.Text;

            Hafiz.WithdrawBalance(withdrawAmount);

            MessageBox.Show("Withdraw Granted");

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            string message = Hafiz.ViewReport();

            MessageBox.Show(message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class InterestCalculator : Form
    {
        public InterestCalculator()
        {
            InitializeComponent();
        }

        private string _programTitle = "Interest Calculator";

        private double _bankrate = 0.0;

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = timeTextBox.Text;

            foreach (char c in temp)
            {
                if (Char.IsDigit(c) == false)
                {
                    MessageBox.Show("Only Numbers are Allowed.", _programTitle);
                    return;
                }
            }
        }

        private void balanceTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = balanceTextBox.Text;

            foreach (char c in temp)
            {
                if ((Char.IsDigit(c) == false) && c != '.')
                {
                    MessageBox.Show("Only Numbers & (.) are Allowed.", _programTitle);
                }
            }

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (balanceTextBox.Text == String.Empty || timeTextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Stream is Empty.", _programTitle);

                return;
            }

            double balance = Convert.ToDouble(balanceTextBox.Text);
            int time = Convert.ToInt32(timeTextBox.Text);

            double interest = (balance * _bankrate * time)/100;

            intersetValuelabel.Text = Math.Round(interest, 2).ToString() + " Taka";

        }

        private void bankNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bankName = bankNamecomboBox.Text;

            if (bankName == "BRAC: 6%")
                _bankrate = 6 ;

            else if (bankName == "DBBL: 7%")
                _bankrate = 7 ;

            else if (bankName == "HSBC: 8%")
                _bankrate = 8 ;

            else
                _bankrate = 1 ;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            timeTextBox.Text = "";
            balanceTextBox.Text = "";
            intersetValuelabel.Text = "0.0";
        }
    }
}

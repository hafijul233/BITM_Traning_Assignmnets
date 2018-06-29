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

        private string programTitle = "Interest Calculator";

        private double bankrate = 0.0;

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = timeTextBox.Text;

            foreach (char c in temp)
            {
                if (Char.IsDigit(c) == false)
                {
                    MessageBox.Show("Only Numbers are Allowed.", programTitle);
                    return;
                }
            }
        }

        private void balanceTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = balanceTextBox.Text;

            foreach (char c in temp)
            {
                if (Char.IsDigit(c) == false && c != '.')
                {
                    MessageBox.Show("Only Numbers & (.) are Allowed.", programTitle);
                    return;
                }
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double balance = Convert.ToDouble(balanceTextBox.Text);
            int time = Convert.ToInt32(timeTextBox.Text);

            double interest = (balance * bankrate * time)/100;

            intersetValuelabel.Text = Math.Round(interest, 2).ToString() + " Taka";

        }

        private void bankNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bankName = bankNamecomboBox.Text;

            if (bankName == "BRAC: 6%")
                bankrate = 6 ;

            else if (bankName == "DBBL: 7%")
                bankrate = 7 ;

            else if (bankName == "HSBC: 8%")
                bankrate = 8 ;

            else
                bankrate = 1 ;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            timeTextBox.Text = "";
            balanceTextBox.Text = "";
            intersetValuelabel.Text = "0.0";
        }
    }
}

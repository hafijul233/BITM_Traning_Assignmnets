using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13LabTestLunchBillCalculator
{
    public partial class LunchBillCalculatorUi : Form
    {
        private string _programTitle = "Lunch Bill Calculator";

        private double _riceUnit = 0.0;

        private double _fishUnit = 0.0;

        private double _meatUnit = 0.0;

        private double _totalPrice = 0.0;

        private double _discount = 0.0;

        private double _netBill = 0.0;

        public LunchBillCalculatorUi()
        {
            InitializeComponent();
        }

        private double TotalPrice(double riceunit, double fishunit, double meatunit)
        {
            double totalprice = (riceunit * 20.00) +
                                (fishunit * 80.00) +
                                (meatunit * 100.00);

            return totalprice;
        }

        private double NetPrice(double total, double discount)
        {
            double includingVat = 0.0;
            double billAfterDiscount = 0.0;

            includingVat = total + ((total * 5) / 100);//5% vat minus korchi

            billAfterDiscount = includingVat - (includingVat * discount) / 100;

            return billAfterDiscount;
        }

        private void StringValidation(string value)
        {

            foreach (char c in value)
            {
                if ((Char.IsDigit(c) == false) && c != '.')
                {
                    MessageBox.Show("Only Numbers and (.) are Allowed.");
                }
            }
        }

        private void RiceUnittextBox_TextChanged(object sender, EventArgs e)
        {
            StringValidation(RiceUnittextBox.Text);
        }

        private void FishUnittextBox_TextChanged(object sender, EventArgs e)
        {
            StringValidation(FishUnittextBox.Text);
        }

        private void MeatUnittextBox_TextChanged(object sender, EventArgs e)
        {
            StringValidation(MeatUnittextBox.Text);
        }


        private void DiscounttextBox_TextChanged(object sender, EventArgs e)
        {
            StringValidation(DiscounttextBox.Text);
        }


        private void ShowTotalButton_Click(object sender, EventArgs e)
        {
            string totalgross = String.Empty;

            if (RiceUnittextBox.Text == String.Empty ||
                FishUnittextBox.Text == String.Empty ||
                MeatUnittextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Field Is Empty.", _programTitle);
            }

            else
            {
                _riceUnit = Convert.ToDouble(RiceUnittextBox.Text);

                _fishUnit = Convert.ToDouble(FishUnittextBox.Text);

                _meatUnit = Convert.ToDouble(MeatUnittextBox.Text);

                _totalPrice = TotalPrice(_riceUnit, _fishUnit, _meatUnit);

                totalgross = String.Format("{0:F1}", _totalPrice);

                TotalGrosstextBox.Text = totalgross;

            }
        }

        private void ShowNetBillButton_Click(object sender, EventArgs e)
        {
            _discount = Convert.ToDouble(DiscounttextBox.Text);

            _netBill = NetPrice(_totalPrice, _discount);

            string replyMessage = "Total Amount To Pay: " + _netBill.ToString();

            MessageBox.Show(replyMessage, _programTitle);

            RiceUnittextBox.Text = String.Empty;
            FishUnittextBox.Text = String.Empty;
            MeatUnittextBox.Text = String.Empty;

            TotalGrosstextBox.Text = String.Empty;
            DiscounttextBox.Text = String.Empty;
        }
    }
}

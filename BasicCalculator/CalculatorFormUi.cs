using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _02BasicCalculator.Class;


namespace _02BasicCalculator
{
    public partial class CalculatorFormUi : Form
    {
        Calculator calculator = new Calculator();

        private string _first = String.Empty;
        private string _second = String.Empty;
        private string _result = String.Empty;

        public CalculatorFormUi()
        {
            InitializeComponent();
        }

        private void firstNumbertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondNumbertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (firstNumbertextBox.Text == String.Empty || secondNumbertextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Field is Empty");
            }
            else
            {
                _first = firstNumbertextBox.Text;
                _second = secondNumbertextBox.Text;

                _result = calculator.Summation(_first, _second);

                resulttextBox.Text = _result;
            }
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (firstNumbertextBox.Text == String.Empty || secondNumbertextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Field is Empty");
            }
            else
            {
                _first = firstNumbertextBox.Text;
                _second = secondNumbertextBox.Text;

                _result = calculator.Subtraction(_first, _second);

                resulttextBox.Text = _result;
            }

        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            if (firstNumbertextBox.Text == String.Empty || secondNumbertextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Field is Empty");
            }
            else
            {
                _first = firstNumbertextBox.Text;
                _second = secondNumbertextBox.Text;

                _result = calculator.Multiplication(_first, _second);

                resulttextBox.Text = _result;
            }

        }

        private void divButton_Click(object sender, EventArgs e)
        {
            if (firstNumbertextBox.Text == String.Empty || secondNumbertextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Field is Empty");
            }
            else
            {
                _first = firstNumbertextBox.Text;
                _second = secondNumbertextBox.Text;

                _result = calculator.Division(_first, _second);

                resulttextBox.Text = _result;
            }
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            if (firstNumbertextBox.Text == String.Empty || secondNumbertextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Field is Empty");
            }
            else
            {
                int firstModEnable = 1;
                int secondModEnable = 1;

                _first = firstNumbertextBox.Text;
                _second = secondNumbertextBox.Text;

                foreach (char c in _first)
                {
                    if (c == '.')
                    {
                        firstModEnable = 0;
                        break;
                    }
                    firstModEnable = 1;
                }

                foreach (char c in _second)
                {
                    if (c == '.')
                    {
                        secondModEnable = 0;
                        break;
                    }
                    secondModEnable = 1;
                }

                if (firstModEnable == 0 || secondModEnable == 0)
                {
                    MessageBox.Show("Modulus Operation Only Works On Non-Fractional Value.");
                }

                else
                {

                    _result = calculator.Modulus(_first, _second);

                    resulttextBox.Text = _result;
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumbertextBox.Text = String.Empty;
            secondNumbertextBox.Text = String.Empty;
            resulttextBox.Text = String.Empty;
        }
    }
}

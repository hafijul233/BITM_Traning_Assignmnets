using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10StandardCalculator
{
    public partial class BasicCalculator : Form
    {
        public BasicCalculator()
        {
            InitializeComponent();
        }

        private void BasicCalculator_Load(object sender, EventArgs e)
        {
            firstNumbertextBox.Text = String.Empty;
            secondNumbertextBox.Text = String.Empty;
            resulttextBox.Text = "0";
        }


        private string _programTitle = "Basic Calculator";
        private string _result = String.Empty;

        void string_validator(string value)
        {
            foreach (char c in value)
            {
                if ((Char.IsDigit(c) == false) && c != '.')
                {
                    MessageBox.Show("Only Numbers and (.) are Allowed.", _programTitle);
                    return;
                }
            }
        }

        private long _intFirst = 0;
        private long _intSecond = 0;

        private double _doubleFirst = 0.0;
        private double _doubleSecond = 0.0;

        private int _firstModEnable = 0;
        private int _secondModEnable = 0;


        private void number_generator(string first, string second)
        {
            foreach (char c in first)
            {
                if (c == '.')
                {
                    _doubleFirst = Convert.ToDouble(first);
                    _firstModEnable = 0;
                    break;
                }

                _intFirst = Convert.ToInt64(first);
                _firstModEnable = 1;
            }

            foreach (char c in second)
            {
                if (c == '.')
                {
                    _doubleSecond = Convert.ToDouble(second);
                    _secondModEnable = 0;
                    break;
                }

                _intSecond = Convert.ToInt64(second);
                _secondModEnable = 1;
            }
        }

        private bool null_checker(string first, string second)
        {
            bool proof; 

            if (first == String.Empty || second == String.Empty)
                proof = true;
            else
                proof =  false;

            return proof;
        }

        private void firstNumbertextBox_TextChanged(object sender, EventArgs e)
        {
            string_validator(firstNumbertextBox.Text);
        }

        private void secondNumbertextBox_TextChanged(object sender, EventArgs e)
        {
           string_validator(secondNumbertextBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (null_checker(firstNumbertextBox.Text, secondNumbertextBox.Text) == true)
            {
                MessageBox.Show("Input Field is Empty.", _programTitle);
                return;
            }

            //number_generator(firstNumbertextBox.Text, secondNumbertextBox.Text);

            _doubleFirst = Convert.ToDouble(firstNumbertextBox.Text);

            _doubleSecond = Convert.ToDouble(secondNumbertextBox.Text);

            double result = _doubleFirst + _doubleSecond;

            _result = Convert.ToString(result);

            resulttextBox.Text = _result;

        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (null_checker(firstNumbertextBox.Text, secondNumbertextBox.Text) == true)
            {
                MessageBox.Show("Input Field is Empty.", _programTitle);
                return;
            }

            //number_generator(firstNumbertextBox.Text, secondNumbertextBox.Text);

            _doubleFirst = Convert.ToDouble(firstNumbertextBox.Text);

            _doubleSecond = Convert.ToDouble(secondNumbertextBox.Text);

            double result = _doubleFirst - _doubleSecond;

            _result = Convert.ToString(result);

            resulttextBox.Text = _result;
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            if (null_checker(firstNumbertextBox.Text, secondNumbertextBox.Text) == true)
            {
                MessageBox.Show("Input Field is Empty.", _programTitle);
                return;
            }

            //number_generator(firstNumbertextBox.Text, secondNumbertextBox.Text);

            _doubleFirst = Convert.ToDouble(firstNumbertextBox.Text);

            _doubleSecond = Convert.ToDouble(secondNumbertextBox.Text);

            double result = _doubleFirst * _doubleSecond;

            _result = Convert.ToString(result);

            resulttextBox.Text = _result;

        }

        private void divButton_Click(object sender, EventArgs e)
        {
            if (null_checker(firstNumbertextBox.Text, secondNumbertextBox.Text) == true)
            {
                MessageBox.Show("Input Field is Empty.", _programTitle);
                return;
            }

            //number_generator(firstNumbertextBox.Text, secondNumbertextBox.Text);

            _doubleFirst = Convert.ToDouble(firstNumbertextBox.Text);

            _doubleSecond = Convert.ToDouble(secondNumbertextBox.Text);

            double result = _doubleFirst / _doubleSecond;

            _result = Convert.ToString(result);

            resulttextBox.Text = _result;
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            if (null_checker(firstNumbertextBox.Text, secondNumbertextBox.Text) == true)
            {
                MessageBox.Show("Input Field is Empty.", _programTitle);
                return;
            }


            foreach (char c in firstNumbertextBox.Text)
            {
                if (c == '.')
                {
                    _firstModEnable = 0;
                    break;
                }
                _firstModEnable = 1;
            }

            foreach (char c in secondNumbertextBox.Text)
            {
                if (c == '.')
                {
                    _secondModEnable = 0;
                    break;
                }
                _secondModEnable = 1;
            }

            if (_firstModEnable == 0 || _secondModEnable == 0)
            {
                MessageBox.Show("Modulus Operation Only Works On Non-Fractional Value.", _programTitle);
                return;
            }

            _intFirst = Convert.ToInt64(firstNumbertextBox.Text);

            _intSecond = Convert.ToInt64(secondNumbertextBox.Text);

            long result = _intFirst % _intSecond;

            _result = Convert.ToString(result);

            resulttextBox.Text = _result;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumbertextBox.Text = String.Empty;
            secondNumbertextBox.Text = String.Empty;
            resulttextBox.Text = "0";
        }

        private void BasicCalculator_FormClosing(object sender, FormClosingEventArgs e)
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




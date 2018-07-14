using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09PurchaseTicketMachince
{
    public partial class PurchaseTicketMachine : Form
    {
        public PurchaseTicketMachine()
        {
            InitializeComponent();
        }

        private string _programTitle = "Ticket Counter";

        private string _firstName = String.Empty;
        private string _lastName = String.Empty;
        private string _fatherName = String.Empty;
        private string _motherName = String.Empty;
        private string _address = String.Empty;
        private string _information = String.Empty;

        private void stringValidator(string value)
        {
            foreach (char c in value)
            {
                if (Char.IsDigit(c) == true)
                {
                    MessageBox.Show("Numbers are not Allowed", _programTitle);
                }
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            stringValidator(firstNameTextBox.Text);
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            stringValidator(lastNameTextBox.Text);
        }

        private void fatherNameTextBox_TextChanged(object sender, EventArgs e)
        {
            stringValidator(fatherNameTextBox.Text);
        }

        private void motherNameTextBox_TextChanged(object sender, EventArgs e)
        {
            stringValidator(motherNameTextBox.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _firstName = firstNameTextBox.Text;
            _lastName = lastNameTextBox.Text;
            _fatherName = fatherNameTextBox.Text;
            _motherName = motherNameTextBox.Text;
            _address = addressTextBox.Text;

            if (_firstName == String.Empty || _lastName == String.Empty ||
                _fatherName == String.Empty || _motherName == String.Empty ||
                _address == String.Empty)
            {
                MessageBox.Show("All fields Must Be Fill-up.", _programTitle);
                return;
            }

            MessageBox.Show("Information Saved Sucessfully.", _programTitle,MessageBoxButtons.OK);

            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
            fatherNameTextBox.Text = String.Empty;
            motherNameTextBox.Text = String.Empty;
            addressTextBox.Text = String.Empty;

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (_firstName == String.Empty || _lastName == String.Empty ||
                _fatherName == String.Empty || _motherName == String.Empty ||
                _address == String.Empty)
            {
                MessageBox.Show("All fields Must Be Fill-up.", _programTitle);
                return;
            }

            _information = "Name: " + _firstName + " " + _lastName + "\n" +
                                 "Father's Name: " + _fatherName + "\n" +
                                 "Mother's Name: " + _motherName + "\n" +
                                 "Address: " + _address + "\n";

            MessageBox.Show(_information, _programTitle,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            if (_firstName == String.Empty || _lastName == String.Empty)
            {
                MessageBox.Show("All fields Must Be Fill-up.", _programTitle);
                return;
            }
            _information = "Name: " + _firstName + " " + _lastName;

            MessageBox.Show(_information, _programTitle,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
        }

        private void parentNameButton_Click(object sender, EventArgs e)
        {
            if (_fatherName == String.Empty || _motherName == String.Empty)
            {
                MessageBox.Show("All fields Must Be Fill-up.", _programTitle);
                return;
            }

            _information = "Father's Name: " + _fatherName + "\n" +
                           "Mother's Name: " + _motherName + "\n";

            MessageBox.Show(_information, _programTitle,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            if (_address == String.Empty)
            {
                MessageBox.Show("All fields Must Be Fill-up.", _programTitle);
                return;
            }
            _information = "Address: " + _address + "\n";

            MessageBox.Show(_information, _programTitle,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
        }

        private void PurchaseTicketMachine_FormClosing(object sender, FormClosingEventArgs e)
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

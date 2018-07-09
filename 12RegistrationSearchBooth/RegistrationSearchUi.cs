using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12RegistrationSearchBooth
{
    public partial class RegistrationSearchUi : Form
    {
        private string _programTitle = "Student Registration Booth";

        private string[,] _studentInfo = new string[20,4];

        public RegistrationSearchUi()
        {
            InitializeComponent();
        }

        private void RegistrationSearchUi_Load(object sender, EventArgs e)
        {
            StudentInfoListView.Columns.Add("Registration No.");
            StudentInfoListView.Columns.Add("Full Name");
            StudentInfoListView.Columns.Add("Class Roll");
            StudentInfoListView.Columns.Add("Address");

        }

        private void StringValidator(string value, bool param)
        {
            foreach (char c in value)
            {
                if (Char.IsDigit(c) == param)
                {
                    if (param == true)
                    {
                        MessageBox.Show("Numbers Not Allowed.", _programTitle);
                    }
                    else
                    {
                        MessageBox.Show("Only Numbers Allowed.", _programTitle);
                    }
                }
            }

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            StringValidator(FullNameTextBox.Text, true);

            
        }

        private void RegistrationNoTextBox_TextChanged(object sender, EventArgs e)
        {   
            StringValidator(RegistrationNoTextBox.Text, false);

        }

        private void ClassRollTextBox_TextChanged(object sender, EventArgs e)
        {
            StringValidator(ClassRollTextBox.Text, false);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text == String.Empty || RegistrationNoTextBox.Text == String.Empty ||
                ClassRollTextBox.Text == String.Empty || AddressTextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Values are Empty", _programTitle);
              
            }
            else
            {
                
            }
        }

        
    }
}

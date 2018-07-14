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

        private string _studentFullname = String.Empty;

        private string _studentRegistrationno = String.Empty;

        private string _studentClassRoll = String.Empty;

        private string _studentAddress = String.Empty;

        private int _studentCounterIndex = 0;

        public RegistrationSearchUi()
        {
            InitializeComponent();
        }

        private void RegistrationSearchUi_Load(object sender, EventArgs e)
        {

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

        private void StudentAddToList(string registationno, string firstname, string classroll, string address)
        {
            ListViewItem student = new ListViewItem(registationno);
            student.SubItems.Add(firstname);
            student.SubItems.Add(classroll);
            student.SubItems.Add(address);

            StudentInfoListView.Items.Add(student);
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
                _studentRegistrationno = RegistrationNoTextBox.Text;
                _studentFullname = FullNameTextBox.Text;
                _studentClassRoll = ClassRollTextBox.Text;
                _studentAddress = AddressTextBox.Text;

                _studentInfo[_studentCounterIndex, 0] = _studentRegistrationno; // registration columns
                _studentInfo[_studentCounterIndex, 1] = _studentFullname; // full name columns
                _studentInfo[_studentCounterIndex, 2] = _studentClassRoll; // class roll
                _studentInfo[_studentCounterIndex, 3] = _studentAddress; // address

                MessageBox.Show("Student Information Registration Completed.", _programTitle);

                StudentAddToList(_studentInfo[_studentCounterIndex, 0], _studentInfo[_studentCounterIndex, 1], _studentInfo[_studentCounterIndex, 2], _studentInfo[_studentCounterIndex, 3]);

                _studentCounterIndex++;

                //clearing form values

                RegistrationNoTextBox.Text = String.Empty;
                FullNameTextBox.Text = String.Empty;
                ClassRollTextBox.Text = String.Empty;
                AddressTextBox.Text = String.Empty;

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            RegistrationNoTextBox.Text = String.Empty;
            FullNameTextBox.Text = String.Empty;
            ClassRollTextBox.Text = String.Empty;
            AddressTextBox.Text = String.Empty;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            StudentInfoListView.Clear();

                StudentInfoListView.Columns.Add("Registration No.", 120);
                StudentInfoListView.Columns.Add("Full Name", 120);
                StudentInfoListView.Columns.Add("Roll", 80);
                StudentInfoListView.Columns.Add("Address", 180);

            if (SearchValueTextBox.Text == String.Empty)
            {
                for (int i = 0; i < _studentCounterIndex; i++)
                {
                    StudentAddToList(_studentInfo[i, 0],
                                     _studentInfo[i, 1],
                                     _studentInfo[i, 2],
                                     _studentInfo[i, 3]);
                }
            }

            else
            {
                string value = SearchValueTextBox.Text;

                bool warning = true;

                for(int i = 0; i<_studentCounterIndex; i++)
                {
                
                    for(int j=0; j<4; j++)
                    {
                        bool searchResult = _studentInfo[i, j].Contains(value);

                        if(searchResult == true)
                        {
                            StudentAddToList(_studentInfo[i, 0],
                                     _studentInfo[i, 1],
                                     _studentInfo[i, 2],
                                     _studentInfo[i, 3]);

                            warning = false;

                            break;
                        }
                    }
                }

                if(warning == true)
                {
                    MessageBox.Show("No Result Found", _programTitle);
                }
            }
        }

        private void SearchValueTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = SearchValueTextBox.Text;

            foreach(char c in temp)
            {
                if(Char.IsPunctuation(c) == true)
                {
                    MessageBox.Show("Punctuations Are not Allowed in Search.", _programTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

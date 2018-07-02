using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingRegistrationApp
{
    public partial class TraningRegistrationForm : Form
    {
        public TraningRegistrationForm()
        {
            InitializeComponent();
        }

        private string _programTitle = "Training Regiatration Booth";

        private string [,] _registrationinfo = new string[10,5];

        private int _lastCount = 0;

        private DataTable _CandidateInfo = new DataTable();

        private void CoursePayment(string CourseName, int durationIndex)
        {
            switch (durationIndex)
            {
                case 0: CostLabel.Text = "30,000";
                    break;

                case 1:
                    CostLabel.Text = "60,000";
                    break;

                case 2:
                    CostLabel.Text = "1,00,000";
                    break;

                default:
                    CostLabel.Text = "0.0";
                    break;
            }
        }

        private void TraningRegistrationForm_Load(object sender, EventArgs e)
        {
            InstituteNamecomboBox.Text = "Please Select a Institute Name";

            _CandidateInfo.Columns.Add("Candidate Name");
            _CandidateInfo.Columns.Add("Institute Name");
            _CandidateInfo.Columns.Add("Applied Course");
            _CandidateInfo.Columns.Add("Course Duration");
            _CandidateInfo.Columns.Add("Course Payment");
        }

        private void candidateNametextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = CandidateNametextBox.Text;

            foreach (char c in temp)
            {
                if (Char.IsDigit(c) == true)
                {
                    MessageBox.Show("Numbers not Allowed.",_programTitle);
                }
            }

        }

        private void InstituteNamecomboBox_TextChanged(object sender, EventArgs e)
        {
            string instituteChoice = InstituteNamecomboBox.Text;

            if (instituteChoice == String.Empty && _lastCount == 0)
            {
                MessageBox.Show("Institute Name Choice is Empty.", _programTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InstituteNamecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            AvaliableCourseComboBox.Items.Clear();
            DurationComboBox.Items.Clear();

            string instituteChoice = InstituteNamecomboBox.Text;

            if (instituteChoice == "Please Select a Institute Name")
            {
                MessageBox.Show("Please First Choice a Institute.", _programTitle,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

            }

            else if (instituteChoice == "BASIS Institute of Technology & Management")
            {
                AvaliableCourseComboBox.Items.Add("Web Design");
                AvaliableCourseComboBox.Items.Add("Graphics & Web UI Design");
                AvaliableCourseComboBox.Items.Add("Web Application Development- Dot Net");
            }

            else if (instituteChoice == "New Horizons")
            {
                AvaliableCourseComboBox.Items.Add("Digital Marketing");
                AvaliableCourseComboBox.Items.Add("Web Application Development- PHP");
                AvaliableCourseComboBox.Items.Add("Practical SEO");

            }

            else if (instituteChoice == "Creative IT Institute")
            {
                AvaliableCourseComboBox.Items.Add("Affiliate Marketing");
                AvaliableCourseComboBox.Items.Add("Customer Support & Service");
                AvaliableCourseComboBox.Items.Add("IT Sales Management");

            }

            else if (instituteChoice == "E-Soft IT Training Center")
            {
                AvaliableCourseComboBox.Items.Add("IT support Technical");
                AvaliableCourseComboBox.Items.Add("Server Administration & Cloud Management");
                AvaliableCourseComboBox.Items.Add("English & Business Communication");

            }

            else if (instituteChoice == "LEADS Training & Consulting Limited")
            {
                AvaliableCourseComboBox.Items.Add("Mobile Application Development (Android)");
                AvaliableCourseComboBox.Items.Add("Software Design and Architecture");
                AvaliableCourseComboBox.Items.Add("Certified Ethical Hacker");

            }
            else
            {
                AvaliableCourseComboBox.Items.Add("No Course Avaliable Righ Now.");
            }
        }

        private void AvaliableCourseComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DurationComboBox.Items.Clear();

            string courseName = AvaliableCourseComboBox.Text;

                DurationComboBox.Items.Insert(0,"3 Months");
                DurationComboBox.Items.Insert(1,"6 Months");
                DurationComboBox.Items.Insert(2,"12 Months");

        }

        private void DurationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int durationIndex = DurationComboBox.Items.IndexOf(DurationComboBox.Text);

            CoursePayment(AvaliableCourseComboBox.Text, durationIndex);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (CandidateNametextBox.Text == String.Empty || InstituteNamecomboBox.Text == String.Empty ||
                AvaliableCourseComboBox.Text == String.Empty || DurationComboBox.Text == String.Empty)
            {
                MessageBox.Show("Input Field Is Empty.",_programTitle);

                return;
            }

                _registrationinfo[_lastCount, 0] = CandidateNametextBox.Text;
                _registrationinfo[_lastCount, 1] = InstituteNamecomboBox.Text;
                _registrationinfo[_lastCount, 2] = AvaliableCourseComboBox.Text;
                _registrationinfo[_lastCount, 3] = DurationComboBox.Text;
                _registrationinfo[_lastCount, 4] = CostLabel.Text;

                _lastCount++;

                MessageBox.Show("Registration Completed!",_programTitle);

            CandidateNametextBox.Text = String.Empty;
            InstituteNamecomboBox.Text = String.Empty;
            AvaliableCourseComboBox.Text = String.Empty;
            DurationComboBox.Text = String.Empty;
            CostLabel.Text = "0.0";
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            if ((CandidateNametextBox.Text == String.Empty || InstituteNamecomboBox.Text == String.Empty ||
                AvaliableCourseComboBox.Text == String.Empty || DurationComboBox.Text == String.Empty) && _lastCount == 0)
            {
                MessageBox.Show("Input Field Is Empty.", _programTitle);

                return;
            }

            string receipt = "\t    Course Registration Information\n" +
                             "--------------------------------------------------------------\n" +
                             "Candidate Name: \t" + _registrationinfo[_lastCount - 1, 0] + "\n" +
                             "Institute Name: \t" + _registrationinfo[_lastCount - 1, 1] + "\n" +
                             "applied Course: \t" + _registrationinfo[_lastCount - 1, 2] + "\n" +
                             "Course Duration: \t" + _registrationinfo[_lastCount - 1, 3] + "\n" +
                             "Payment: \t\t" + _registrationinfo[_lastCount - 1, 4] + "Taka Only";

            MessageBox.Show(receipt, _programTitle, MessageBoxButtons.OK);
        }

        private void RegiatrationFormTabControl_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < _lastCount; i++)
            {
                _CandidateInfo.Rows.Add(new object[] { _registrationinfo[i,0], _registrationinfo[i,1], _registrationinfo[i,2], _registrationinfo[i,3], _registrationinfo[i,4]});
            }

            candidateDataGridView.DataSource = _CandidateInfo;

        }
    }
}

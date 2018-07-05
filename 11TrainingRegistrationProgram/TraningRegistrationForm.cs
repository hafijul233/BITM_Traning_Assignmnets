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

        private string [,] _registrationinfo = new string[10,6];

        private int _lastCount = 0;

        private int _durationIndex = 0;

        private DataTable _CandidateInfo = new DataTable();

        private void CoursePayment(int durationIndex, string seat)
        {
            int seats = Convert.ToInt32(seat);

            double price = 0.0;

            switch (durationIndex)
            {
                case 0: price = 30000.00;
                    break;

                case 1:
                    price = 60000.00;
                    break;

                case 2:
                    price = 100000.00;
                    break;

                default:
                    price = 0.0;
                    break;
            }

            price = seats * price;

            CostLabel.Text = price.ToString();
        }

        private void TraningRegistrationForm_Load(object sender, EventArgs e)
        {
            InstituteNamecomboBox.Text = "Please Select a Institute Name";

            _CandidateInfo.Columns.Add("Candidate Name");
            _CandidateInfo.Columns.Add("Institute Name");
            _CandidateInfo.Columns.Add("Applied Course");
            _CandidateInfo.Columns.Add("Course Duration");
            _CandidateInfo.Columns.Add("Course Payment");
            _CandidateInfo.Columns.Add("Seats");
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
            _durationIndex = DurationComboBox.Items.IndexOf(DurationComboBox.Text);

            string seatNumber = SeatTextBox.Text;

            CoursePayment(_durationIndex, seatNumber);

        }

        private void SeatTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = SeatTextBox.Text;
            int seatSize = 0;
            if (temp.Length == 0)
            {
                SeatTextBox.Text = "1";
            }

            else{

                seatSize = Convert.ToInt32(temp);

                foreach (char c in temp)
                {
                    if (Char.IsDigit(c) == false)
                    {
                        MessageBox.Show("Only Numbers Are Allowed.", _programTitle);
                    }
                }
            }

            if (seatSize < 1 || seatSize > 15 || temp.Length > 2)
            {
                MessageBox.Show("Seat Reservation Range between 1 to 15.", _programTitle);
            }
            else
            {
                CoursePayment(_durationIndex, temp);
            }

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
                _registrationinfo[_lastCount, 5] = SeatTextBox.Text;

                _lastCount++;

                MessageBox.Show("Registration Completed!",_programTitle);

            CandidateNametextBox.Text = String.Empty;
            InstituteNamecomboBox.Text = String.Empty;
            AvaliableCourseComboBox.Text = String.Empty;
            DurationComboBox.Text = String.Empty;
            SeatTextBox.Text = "";
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
                             "Seat Reservation: \t" + _registrationinfo[_lastCount - 1, 5] + "\n" +
                             "Payment: \t\t" + _registrationinfo[_lastCount - 1, 4] + "Taka Only";

            MessageBox.Show(receipt, _programTitle, MessageBoxButtons.OK);
        }

        private void RegiatrationFormTabControl_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < _lastCount; i++)
            {
                _CandidateInfo.Rows.Add(new object[] { _registrationinfo[i,0], _registrationinfo[i,1], _registrationinfo[i,2], _registrationinfo[i,3], _registrationinfo[i,4], _registrationinfo[i, 5] });
            }

            candidateDataGridView.DataSource = _CandidateInfo;

        }

    }
}

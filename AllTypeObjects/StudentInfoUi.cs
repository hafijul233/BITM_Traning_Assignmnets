using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllTypeObjects.Classes

namespace AllTypeObjects
{
    public partial class StudentInfoUi : Form
    {
        public StudentInfoUi()
        {
            InitializeComponent();
        }

        Student Hafiz = new Student();

        private void DeptComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void SemesterComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text == String.Empty || RegistrationNoTextBox.Text == String.Empty ||
               DeptComboBox.Text == String.Empty || CourseTextBox.Text == String.Empty ||
               SemesterComboBox.Text == String.Empty || ClassRollTextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Field Empty");
            }
            else
            {
                Hafiz.GetStudentInfo(FullNameTextBox.Text, RegistrationNoTextBox.Text,
                                     DeptComboBox.Text, CourseTextBox.Text,
                                     SemesterComboBox.Text, ClassRollTextBox.Text);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {

        }
    }
}

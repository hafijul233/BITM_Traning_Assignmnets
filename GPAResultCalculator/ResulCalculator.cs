using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPAResultCalculator.Models;

namespace GPAResultCalculator
{
    public partial class ResulCalculator : Form
    {
        private const string _programTitle = "Result Calculator";

        public ResulCalculator()
        {
            InitializeComponent();
        }

        private void StringValidator(string value)
        {
            foreach(char c in value)
            {
                if(Char.IsDigit(c) == false && c!= '.')
                {
                    MessageBox.Show("Unauthorized Value.", _programTitle);
                }
            }
        }

        private void PhysicsResultTextBox_TextChanged(object sender, EventArgs e)
        {
            StringValidator(PhysicsResultTextBox.Text);
        }

        private void ChemistryResultTextBox_TextChanged(object sender, EventArgs e)
        {
            StringValidator(ChemistryResultTextBox.Text);
        }

        private void MathResultTextBox_TextChanged(object sender, EventArgs e)
        {
            StringValidator(MathResultTextBox.Text);
        }

        Student Hafiz = new Student();

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if(PhysicsResultTextBox.Text == String.Empty ||
               ChemistryResultTextBox.Text == String.Empty ||
               MathResultTextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Field is Empty", _programTitle);
            }

            else
            {
                Hafiz.PhysicsMarks = PhysicsResultTextBox.Text;
                Hafiz.ChemistryMarks = ChemistryResultTextBox.Text;
                Hafiz.MathMarks = MathResultTextBox.Text;

                AverageResultTextBox.Text = Hafiz.AverageResult;
                GradeTextBox.Text = Hafiz.GPA;
            }
        }
    }
}

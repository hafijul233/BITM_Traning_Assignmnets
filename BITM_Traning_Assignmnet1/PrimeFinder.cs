using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITM_Traning_Assignmnet1
{
    public partial class PrimeFinder : Form
    {
        public PrimeFinder()
        {
            InitializeComponent();
        }

        private string programTile = "Prime Finder";

        private void PrimeFinder_Load(object sender, EventArgs e)
        {
            inputnumbertextBox.Text = "0";
        }

        private void inputnumbertextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = inputnumbertextBox.Text;
            foreach (char c in temp)
            {
                if (Char.IsDigit(c) == false)
                {
                    MessageBox.Show("Only Numbers are Allowed.",programTile);
                }
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string stringNumber = inputnumbertextBox.Text;

            string replyMessage = String.Empty;
            int proof = 0;

            if (stringNumber.Length > 19)
            {
                MessageBox.Show("Input is Too BIG for Calculation.", programTile);
            }

            else if (stringNumber == "0" || stringNumber == "1")
            {
                replyMessage = stringNumber + " is not a Prime Number.";
            }

            else if (stringNumber == "2")
            {
                replyMessage = stringNumber + " is a Prime Number.";
            }

            else
            {
                ulong integerNumber = Convert.ToUInt64(stringNumber);
                ulong range = (ulong)Math.Sqrt(integerNumber);

                for (ulong i = 2; i <= range; i++)
                {
                    if (integerNumber % i == 0)
                    {
                        proof = 1;
                        break;
                    }
                }

                switch (proof)
                {
                    case 1:
                        replyMessage = integerNumber.ToString() + " is not a Prime Number.";
                        break;
                    default:
                        replyMessage = integerNumber.ToString() + " is a Prime Number.";
                        break;
                }

                var dialogResult = MessageBox.Show(replyMessage, programTile, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.OK)
                {
                    inputnumbertextBox.Text = String.Empty;
                }
            }
        }

        private void PrimeFinder_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure to Quit!", programTile, MessageBoxButtons.YesNo);

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

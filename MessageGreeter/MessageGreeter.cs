using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02MessageGreeter
{
    public partial class MessageGreeter : Form
    {
        public MessageGreeter()
        {
            InitializeComponent();
        }

        private string programTitle = "Greeter Machine";

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = fullNameTextBox.Text;

            foreach (char c in temp)
            {
                if (Char.IsDigit(c) == true)
                {
                    MessageBox.Show("Numbers are not Allowed.", programTitle);

                    return;
                }
            }
        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            string insertedName = fullNameTextBox.Text;

            string greetMessage = "Hi " + insertedName + ", have a nice day.";

            MessageBox.Show(greetMessage, programTitle, 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Exclamation);
        }

        private void MessageGreeter_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure to Quit!", programTitle,
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

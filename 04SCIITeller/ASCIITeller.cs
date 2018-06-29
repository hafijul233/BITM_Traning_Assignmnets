using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04SCIITeller
{
    public partial class ASCIITeller : Form
    {
        public ASCIITeller()
        {
            InitializeComponent();
        }

        private string programTitle = "ASCI TELLER";

        private void charactertextBox_TextChanged(object sender, EventArgs e)
        {
            string temp = charactertextBox.Text;
            if (temp.Length == 0) { }

            else if (temp.Length > 1)
                MessageBox.Show("Only Enter a Single Character.", programTitle);

            else
            {
                char character = Convert.ToChar(temp);

                if ((int) character >= 256)
                {
                    MessageBox.Show("ASCII Table Doesn't support this Character.", programTitle);

                    charactertextBox.Text = "";
                }
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string inputString = charactertextBox.Text;

            string replyMessage = String.Empty;

            if (inputString == "")
            {
                replyMessage = "Input Stream is Empty";
            }

            else
            {
                char character = Convert.ToChar(inputString);

                int asciiValue = (int) character;

                replyMessage = $"ASCII Value of \"{character}\" is : {asciiValue}.";

            }

            MessageBox.Show(replyMessage, programTitle);

            charactertextBox.Text = "";

        }

        private void ASCIITeller_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

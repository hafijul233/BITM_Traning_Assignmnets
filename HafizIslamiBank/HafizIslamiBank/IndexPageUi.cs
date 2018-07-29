using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HafizIslamiBank.Views;

namespace HafizIslamiBank
{
    public partial class IndexPageUi : Form
    {
        public IndexPageUi()
        {
            InitializeComponent();
        }

        private void IndexPageUi_Load(object sender, EventArgs e)
        {

        }

        private void SaveCustomerinfolinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerEntyUi entyForm = new CustomerEntyUi();
            this.Hide();
            entyForm.Show();
        }

        private void TransactionlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransactionUi transactionForm = new TransactionUi();
            this.Hide();
            transactionForm.Show();
        }

        private void SearchCustomerInfolinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchAccountInfoUi searchAccountForm = new SearchAccountInfoUi();
            this.Hide();
            searchAccountForm.Show();
        }

        private void IndexPageUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogueResult = MessageBox.Show("Are you Really want to Quit?", "Hafiz Islami Bank",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogueResult == DialogResult.Yes)
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

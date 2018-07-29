using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HafizIslamiBank.Models;

namespace HafizIslamiBank.Views
{
    public partial class TransactionUi : Form
    {
        public TransactionUi()
        {
            InitializeComponent();
        }

        private void TransactionUi_FormClosed(object sender, FormClosedEventArgs e)
        {
            IndexPageUi indexForm = new IndexPageUi();
            this.Hide();
            indexForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //double amount = Convert.ToDouble(Amu)
        
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
    }
}

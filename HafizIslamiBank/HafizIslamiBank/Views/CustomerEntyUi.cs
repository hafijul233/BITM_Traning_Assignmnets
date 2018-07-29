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
using  HafizIslamiBank.Models;

namespace HafizIslamiBank.Views
{
    public partial class CustomerEntyUi : Form
    {
        public CustomerEntyUi()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerEntyUi_FormClosed(object sender, FormClosedEventArgs e)
        {
            IndexPageUi indexForm = new IndexPageUi();
            this.Hide();
            indexForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameTextBox.Text == String.Empty || EmailTextBox.Text == String.Empty || AccountNumberTextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Field is Missing");
            }
            else
            {
                 Customer Hridoy = new Customer();
                
                Hridoy._name = CustomerNameTextBox.Text;
                Hridoy._email = EmailTextBox.Text;
                Hridoy._accountNumber = Convert.ToInt64(AccountNumberTextBox.Text);
                Hridoy._openingdate = OpenigdateTimePicker.Text;
                Hridoy._balance = 0;

                int result = SaveCustomer(Hridoy);
                if (result != 0)
                {
                    MessageBox.Show("New Customer Registration Completed.");
                }
                else
                {
                    MessageBox.Show("New Customer Registration Failed.");  
                }
            }
        }

        public int SaveCustomer(Customer person)
        {

            string conString = @"server=PC-301-16\SQLEXPRESS; database=HafizBank; integrated security=true;";

            SqlConnection conection = new SqlConnection(conString);

            string query = @"INSERT INTO CustomerInfo(AccountNumber, CustomerName, EmailAddress, OpeningDate, Balance)" +
                            "VALUES ('" + person._accountNumber + "', '" + person._name + "', '" + person._email + "', '" + person._openingdate + "', '" + person._balance + "')";

            SqlCommand command = new SqlCommand(query, conection);

            conection.Open();

            int isRowAffected = command.ExecuteNonQuery();

            conection.Close();

            return isRowAffected;

        }
    }
}

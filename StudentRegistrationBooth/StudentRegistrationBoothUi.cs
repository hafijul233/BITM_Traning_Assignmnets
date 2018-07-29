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
using StudentRegistrationBooth.Models;

namespace StudentRegistrationBooth
{
    public partial class StudentRegistrationBoothUi : Form
    {
        private string _programTitle = "Student Registration Booth";

        private SqlConnection connection;

        public StudentRegistrationBoothUi()
        {
            InitializeComponent();
        }

        private void DatabaseConection()
        {
            string conString = @"server=HRIDOY-PC\SQLEXPRESS; database=CustomerBooth; integrated security=true;";

             connection = new SqlConnection(conString);
        }

        private void StudentRegistrationBoothUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure to Quit!", _programTitle,
                MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }

            else
            {
                e.Cancel = true;
            }

        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            Customer customer = new Customer();

            string code = CustomerCodeTextBox.Text;
            string name = CustomerNameTextBox.Text;
            string contactNo = ContactNumberTextBox.Text;
            string birthdate = BirthDatePicker.Text;
            string address = AddressTextBox.Text;
            string subDistrict = SubDistrictComboBox.Text;
            string district = DistrictComboBox.Text;

            customer.GetCustomerInfo(code, name, contactNo, birthdate, address, subDistrict, district);

            //MessageBox.Show(code + "\n" + name + "\n" + contactNo + "\n" + birthdate + "\n" + address + "\n" + subDistrict + "\n" + district);

            if (InsertCustomer(customer) != 0)
            {
                MessageBox.Show("Customer Added Successfull");
            }
            else
            {
                MessageBox.Show("Customer Added Failed");
            }
        }
        
        private int InsertCustomer(Customer person)
        {
            int result;

            DatabaseConection();

            string query = @"INSERT INTO CustomerInfo(CustoerCode, CustomerName, ContactNumber, BirthDate, CustomerAddress, SubDistrict, District)"
                          + "VALUES ('" + person._code + "', '" + person._name + "', '" + person._contactNo + "', '" + person._birthDate + "', '" 
                          + person._contactNo + "', '" + person._address +"', '" + person._subDistrict + "', '" + person._district + ")";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();


            result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }
    }
}

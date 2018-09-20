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
using CustomerManager.Models;

namespace CustomerManager
{
    public partial class CustomerRegistrationUi : Form
    {
        private List<Customer> CustomerList = new List<Customer>();
        private SqlConnection _connection;
        private List<string> SubdistrictList = new List<string>();
        private List<string> DistrictList = new List<string>();
        private int resultIndex = -1;

        public CustomerRegistrationUi()
        {
            InitializeComponent();
        }

        private void CustomerRegistrationUi_Load(object sender, EventArgs e)
        {
            _connection = new SqlConnection(@"server=HRIDOY-PC\SQLEXPRESS; database=CustomerManager; integrated security=true;");

            //Add All SubDistricts

            string query = "SELECT Subdistrict FROM SubDistrictInfo";

                SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    string subdistrict = dataReader.GetString(dataReader.GetOrdinal("Subdistrict"));
                    SubdistrictList.Add(subdistrict);
                }
            }

            _connection.Close();


            //Add All district to lst

            query = "SELECT District FROM DistrictInfo";
            command = new SqlCommand(query, _connection);

            _connection.Open();

            dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    string district = dataReader.GetString(dataReader.GetOrdinal("District"));
                    DistrictList.Add(district);
                }
            }
            _connection.Close();

            foreach (var subdisk in SubdistrictList)
            {
                SubDistrictComboBox.Items.Add(subdisk.ToString());
            }

            foreach (var distisk in DistrictList)
            {
                DistrictComboBox.Items.Add(distisk.ToString());
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            if(SaveButton.Text == "Save")
            {
                
                customer.Code = CodeTextBox.Text;
                customer.Name = NameTextBox.Text;
                customer.ContactNo = ContactNoTextBox.Text;
                customer.Dateofbirth = BirthateTimePicker.Text;
                customer.Email = EmailTextBox.Text;
                customer.Subdistrict = SubDistrictComboBox.Text;
                customer.District = DistrictComboBox.Text;

                int errorReturn = CustomerEntry(customer);

                if (errorReturn != 0)
                {
                    MessageBox.Show("New Customer Registered!");

                    CustomerList.Add(customer);

                    CodeTextBox.Text = String.Empty;
                    NameTextBox.Text = String.Empty;
                    ContactNoTextBox.Text = String.Empty;
                    BirthateTimePicker.Text = String.Empty;
                    EmailTextBox.Text = String.Empty;
                    SubDistrictComboBox.Text = String.Empty;
                    DistrictComboBox.Text = String.Empty;
                }

                else
                {
                    MessageBox.Show("New Customer Registration Failed");
                }
            }

            else if(SaveButton.Text == "Update")
            {
                customer.Code = CodeTextBox.Text;
                customer.Name = NameTextBox.Text;
                customer.ContactNo = ContactNoTextBox.Text;
                customer.Dateofbirth = BirthateTimePicker.Text;
                customer.Email = EmailTextBox.Text;
                customer.Subdistrict = SubDistrictComboBox.Text;
                customer.District = DistrictComboBox.Text;

                
            }

            else
            {
                MessageBox.Show("There is a Problem");
            }
        }
        
        private int CustomerEntry(Customer newcustomer)
        {
            string query = @"INSERT INTO CustomerInfo(CustomerCode, CustomerName, ContactNumber, BirthDate, EmailAddress, SubDistrict, District)"
                          + "VALUES ('" + newcustomer.Code + "', '" + newcustomer.Name + "', '" + newcustomer.ContactNo + "', '" +
                          newcustomer.Dateofbirth + "', '" + newcustomer.Email + "', '" + newcustomer.Subdistrict + "', '" +
                          newcustomer.District + "')";

            //4 SQL Command

            SqlCommand command = new SqlCommand(query, _connection);

            //5 Connection Open
            _connection.Open();

            //6 Execute


            //int affectedCount = command.ExecuteNonQuery();
            //if (affectedCount>0)
            //{

            //}
            int isRowAffected;

            if (command.ExecuteNonQuery() > 0)

                isRowAffected = 1;
            else
                isRowAffected = 0;


            //7 Connection Close
            _connection.Close();

            return isRowAffected;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchCode = SearchTextBox.Text;
            
            for(int i=0; i < CustomerList.Count; i++)
            {
                Customer Member = CustomerList[i];

                if(Member.Code == searchCode)
                {
                    resultIndex = i;
                }
            }

            if(resultIndex == -1)
            {
                MessageBox.Show("Code Didn't match any User Info");
            }
            else
            {
                Customer customer = CustomerList[resultIndex];

                Codelabel.Text =  customer.Code + "Index=" + resultIndex;
                Namelabel.Text = customer.Name;
                ContactNolabel.Text = customer.ContactNo;
                Birthdatelabel.Text = customer.Dateofbirth;
                Emaillabel.Text = customer.Email;
                SubDistrictlabel.Text = customer.Subdistrict;
                Districtlabel.Text = customer.District;

            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SaveButton.Text = "Update";
            SaveButton.BackColor = Color.Green;

            Customer customer = CustomerList[resultIndex];

            CodeTextBox.Text = customer.Code;
            NameTextBox.Text = customer.Name;
            ContactNoTextBox.Text = customer.ContactNo;
            BirthateTimePicker.Text = customer.Dateofbirth;
            EmailTextBox.Text = customer.Email;
            SubDistrictComboBox.Text = customer.Subdistrict;
            DistrictComboBox.Text = customer.District;
        }

        
    }
}

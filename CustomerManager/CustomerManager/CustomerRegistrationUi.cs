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

        public CustomerRegistrationUi()
        {
            InitializeComponent();
        }

        private void CustomerRegistrationUi_Load(object sender, EventArgs e)
        {
            _connection = new SqlConnection(@"server=HRIDOY-PC\SQLEXPRESS; database=CustomerManager; integrated security=true;");

            //Add All SubDistricts

            string query = "SELECT SubDistrict FROM SubDistrictInfo";

                SqlCommand command = new SqlCommand(query, _connection);

            _connection.Open();

            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
               foreach(dynamic subdistric in dataReader)
                {
                    MessageBox.Show(subdistric.Name[""])
                }
            }

            _connection.Close();


            //Add All district to lst

            query = "SELECT District FROM DistrictInfo";
            command = new SqlCommand(query, _connection);

            _connection.Open();

            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                foreach (var name in dataReader)
                {
                    string districtName = name.ToString();
                    DistrictComboBox.Items.Add(districtName);
                }
            }
            _connection.Close();*/
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
            string query = @"INSERT INTO CustomerInfo(CustomerCode, CustomerName, ContactNumber, BirthDate, SubDistrict, District)"
                          + "VALUES ('" + newcustomer.Code + "', '" + newcustomer.Name + "', '" + newcustomer.ContactNo + "', '" + newcustomer.Dateofbirth + "', '" + newcustomer.Email + "')";

            //4 SQL Command

            SqlCommand command = new SqlCommand(query, con);

            //5 Connection Open
            con.Open();

            //6 Execute


            //int affectedCount = command.ExecuteNonQuery();
            //if (affectedCount>0)
            //{

            //}

            bool isRowAffected = command.ExecuteNonQuery() > 0;


            //7 Connection Close
            con.Close();

            return isRowAffected;
            return 0;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchCode = SearchTextBox.Text;
            int resultIndex = -1;
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

            /*Customer customer = CustomerList[0
                ];

            CodeTextBox.Text = customer.Code;
            NameTextBox.Text = customer.Name;
            ContactNoTextBox.Text = customer.ContactNo;
            BirthateTimePicker.Text = customer.Dateofbirth;
            EmailTextBox.Text = customer.Email;
            SubDistrictTextBox.Text = customer.Subdistrict;
            DistrictTextBox.Text = customer.District;*/
        }

        
    }
}

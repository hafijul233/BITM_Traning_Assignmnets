using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Control_Panel.Models;

namespace Vehicle_Control_Panel
{
    public partial class VehicleControllerUi : Form
    {
        private string _programTitle = "Vehicle Controller";

        public VehicleControllerUi()
        {
            InitializeComponent();
        }

        Vehicles _corolla;

        private void CreateButton_Click(object sender, EventArgs e)
        {
           if(VehicleNameTextBox.Text == String.Empty || RegNoTextBox.Text == String.Empty)
            {
                MessageBox.Show("Input Field is Empty.", _programTitle);
            }
            else
            {
                string vehicleName = VehicleNameTextBox.Text;
                string regNo = RegNoTextBox.Text;

                _corolla = new Vehicles(vehicleName, regNo);

                VehicleNameTextBox.Text = String.Empty;
                RegNoTextBox.Text = String.Empty;
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            _corolla.AddSpeed = SpeedTextBox.Text;

            SpeedTextBox.Text = String.Empty;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            _corolla.GetMinMaxAvgSpeed();

            MinSpeedTextBox.Text = _corolla.MinSpeed;
            MaxSpeedTextBox.Text = _corolla.MaxSpeed;
            AvgSpeedTextBox.Text = _corolla.AvgSpeed;

            string message = "Model Name: " + _corolla.Name + "\nReg No: " + _corolla.RegNo;
            MessageBox.Show(message);

        }
    }
}

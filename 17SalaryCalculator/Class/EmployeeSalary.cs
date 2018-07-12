using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SalaryCalculator.Class
{
    class EmployeeSalary
    {
        private string _employeeName;
        private double _basicAmount;
        private double _houseRent;
        private double _medicalAllowance;
        private double _totalSalary;

        public string GetNetSalary(string empName, string basicamount, string houserent, string medical)
        {
            _employeeName = empName;
            _basicAmount = Convert.ToDouble(basicamount);
            _houseRent = (Convert.ToDouble(houserent) * _basicAmount) / 100;
            _medicalAllowance = (Convert.ToDouble(medical) * _basicAmount) / 100;

            _totalSalary = _basicAmount + _houseRent + _medicalAllowance;

            string message = _employeeName + " your salary is: " + String.Format("{0:F2}",_totalSalary) + " Taka Only.";

            return message;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BankAccountQuery.Class
{
    class AccountInfo
    {
        private string CustomerName;
        private string  AccountNumber;
        private double AccountBalance = 500;
    
        public void CreateAccount(string accountNo, string customerName)
        {
            CustomerName = customerName;
            AccountNumber = accountNo;
        }

        public void DepositBalance(string value)
        {
            AccountBalance = AccountBalance + Convert.ToDouble(value);
        }

        public void WithdrawBalance(string value)
        {
            AccountBalance = AccountBalance - Convert.ToDouble(value);
        }

        public string ViewReport()
        {
            string report = CustomerName + ", " + "your account number: SV - " + AccountNumber
                             + "and it's balance: " + AccountBalance + ".";
            return report;
        }


    }
}

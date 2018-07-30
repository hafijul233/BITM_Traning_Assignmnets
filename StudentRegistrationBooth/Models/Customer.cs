using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationBooth.Models
{
    class Customer
    {
        public string _code { get; set; }
        public string _name;
        public string _contactNo;
        public string _birthDate;
        public string _address;
        public string _subDistrict;
        public string _district;

        public void GetCustomerInfo(string code, string name, string contactNo, string birthDate,
                                    string address, string subDistrict, string district)
        {
            _code = code;
            _name = name;
            _contactNo = contactNo;
            _birthDate = birthDate;
            _address = address;
            _subDistrict = subDistrict;
            _district = district;
        }

    }
}

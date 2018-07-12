using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTypeObjects.Classes
{
    class Student
    {
        private string _fullName;
        private ulong _registrationNumber;
        private string _departmentName;
        private string _courseName;
        private int _semester;
        private uint _classRoll;

        public void GetStudentInfo(string fullname, string regino, string dept, string course, string semester, string roll)
        {
            _fullName = Convert.ToString(fullname);
            _registrationNumber = Convert.ToUInt64(regino);
            _departmentName = Convert.ToString(dept);
            _courseName = Convert.ToString(course);
            _semester = Convert.ToInt32(semester);
            _classRoll = Convert.ToUInt32(roll);
        }

        public object PutStudentInfo(Student person)
        {
            person._fullName
        }
    }
}

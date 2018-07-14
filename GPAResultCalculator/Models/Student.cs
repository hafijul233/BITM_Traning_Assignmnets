using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAResultCalculator.Models
{
    class Student
    {
        private double _physicsResult;
        private double _chemistryResult;
        private double _mathResult;

        private double _averageResult;
        private string _gpaGrade;


        private double GetAverageResult()
        {
            _averageResult = (_physicsResult + _chemistryResult + _mathResult) / 3.0;

            return _averageResult;
        }

        private string GetGpaGrade()
        {
            string grade;

            if (_averageResult >= 80) grade = "A+";

            else if (_averageResult >= 70 && _averageResult < 80) grade = "B+";

            else if (_averageResult >= 60 && _averageResult < 70) grade = "C+";

            else if (_averageResult >= 50 && _averageResult < 60) grade = "D+";

            else grade = "F";

            return grade;
        }

        public string PhysicsMarks
        {
            set { _physicsResult = Convert.ToDouble(value); }
        }

        public string ChemistryMarks
        {
            set { _chemistryResult = Convert.ToDouble(value); }
        }

        public string MathMarks
        {
            set { _mathResult = Convert.ToDouble(value); }
        }

        public string AverageResult => String.Format("{0:F2}", GetAverageResult());

        public string GPA => GetGpaGrade();


    }
}

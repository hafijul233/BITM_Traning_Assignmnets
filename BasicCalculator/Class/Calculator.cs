using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BasicCalculator.Class
{
    class Calculator
    {
        private double FirstValue;
        private double SecondValue;
        private double Result;

        public string Summation(string first, string second)
        {
            FirstValue = Convert.ToDouble(first);
            SecondValue = Convert.ToDouble(second);

            Result = FirstValue + SecondValue;

            return Result.ToString();
        }

        public string Subtraction(string first, string second)
        {
            FirstValue = Convert.ToDouble(first);
            SecondValue = Convert.ToDouble(second);

            Result = FirstValue - SecondValue;

            return Result.ToString();
        }

        public string Multiplication(string first, string second)
        {
            FirstValue = Convert.ToDouble(first);
            SecondValue = Convert.ToDouble(second);

            Result = FirstValue * SecondValue;

            return Result.ToString();
        }

        public string Division(string first, string second)
        {
            FirstValue = Convert.ToDouble(first);
            SecondValue = Convert.ToDouble(second);

            Result = FirstValue / SecondValue;

            return Result.ToString();
        }

        public string Modulus(string first, string second)
        {
            long firstvalue = Convert.ToInt64(first);
            long secondvalue = Convert.ToInt64(second);

            long result = firstvalue % secondvalue;

            return result.ToString();
        }

    }
}

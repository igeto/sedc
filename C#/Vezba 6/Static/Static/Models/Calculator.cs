using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Models
{
    public static class Calculator
    {
        public static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static double SquareRoot(double number)
        {
            return Math.Sqrt(number);
        }
    }
}

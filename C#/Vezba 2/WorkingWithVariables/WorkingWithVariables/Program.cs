using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = x + 5;

            //Console.WriteLine(y);
            //Console.ReadLine();
            //int firstNumber = 20;
            //int secondNumber = 10;

            //int result = firstNumber + secondNumber;
            //Console.WriteLine(result);
            //Console.ReadLine();
            SimpleDoubleCalculator();
            SimpleIntegercalculator();
            FunWithStrings();
            ConcatStrangeThings();
            Credits();
            Console.ReadLine();
        }

        static void SimpleDoubleCalculator()
        {
            double firstNumber = 50.25;
            double secondNumber = 10;

            Console.WriteLine(firstNumber / secondNumber);
        }
        static void SimpleIntegercalculator()
        {
            int firstNum = 10;
            int secondNum = 20;
            int result = firstNum * secondNum;
            Console.WriteLine(result);
        }
        static void FunWithStrings()
        {
            string firstName = "Igor";
            string middleName = "Igeto";
            string lastName = "Mitkovski";

            string fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine(fullName);
        }
        static void DataConversion()
        {
            string a = "5";
            string b = "7";

            string result = a + b;
        }
        static void ConcatStrangeThings()
        {
            int a = 9;
            string b = "gag";

            Console.WriteLine(a + b);
        }
        static void Credits()
        {
            int credits = 102;
            int smsCost = 5;
            double result = credits / smsCost;
            //Math.Truncate(result);
            Console.WriteLine(result);

        }
    }
}

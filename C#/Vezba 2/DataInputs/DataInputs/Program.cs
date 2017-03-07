using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //Console.Write("Type your first name: ");

            //string firstName;
            //firstName = Console.ReadLine();
            //string lastName;
            //Console.Write("Type your last name " + firstName + ": ");
            //lastName = Console.ReadLine();
            //Console.WriteLine("Hello " + firstName + " " + lastName);
            //SumCalculator();
            MaxOfTwoNumbers();
            Console.Read();
        }
        static void SumCalculator()
        {
            int firstNumber;
            int secondNumber;
            int result;

            Console.Write("Insert first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            result = firstNumber + secondNumber;
            Console.WriteLine("The sum of the two numbers you entered is " + result);
            Console.ReadLine();
        }
        static void MaxOfTwoNumbers()
        {
            Console.Write("Please enter a number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter anoter number: ");
            int secondnumer = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondnumer)
            {
                Console.WriteLine(firstNumber + " is bigger than " + secondnumer);
            }
            else if (secondnumer > firstNumber)
            {
                Console.WriteLine(secondnumer + " is bigger than " + firstNumber);
            }
            else
            {
                Console.WriteLine("The numbers are of equal value");
            }

        }
    }
}

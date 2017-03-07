using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Where do you live: ");
            string city = Console.ReadLine();
            string reversedFirstName = ReverseString(firstName);
            string reversedLastName = ReverseString(lastName);
            string reversedCity = ReverseString(city);
            DisplayResult(reversedFirstName, reversedLastName, reversedCity);
            DisplayResult(firstName, lastName, city);
            DisplayResult(firstName);
            DisplayResult(firstName + " " + lastName + " " + city);
            Console.ReadLine();
        }
        static string ReverseString(string message)
        {
            string result = string.Empty;
            char[] charArray = message.ToArray();
            Array.Reverse(charArray);
            foreach (char item in charArray)
            {
                result += item;
            }
            return result;
        }
        /// <summary>
        /// Expects three arguments of type string and prints them
        /// </summary>
        /// <param name="firstName">First argument type string</param>
        /// <param name="lastName">Second argument type string</param>
        /// <param name="city">Third argument type string</param>
        static void DisplayResult(string firstName, string lastName, string city)
        {
            Console.WriteLine("Result: ");
            Console.WriteLine("{0} {1} {2}", firstName, lastName, city);
        }
        static void DisplayResult(string message)
        {
            Console.WriteLine("Result:");
            Console.WriteLine(message);
        }
    }
}

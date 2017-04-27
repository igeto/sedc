using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("Choose an option");
            Console.WriteLine(" 1) Create new Manager");
            Console.WriteLine(" 2) Choose Manager");
            Console.WriteLine(" 0) Exit");

            string result = Console.ReadLine();
            if (result == "1")
            {

                return true;
            }
            else if (result == "2")
            {
                return true;
            }
            else if (result == "0")
            {
                return false;
            }
            else
                return true;
        }
        private static void CreateNewManager()
        {
            Console.WriteLine("Create new manager");

            Console.Write("Insert ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Insert first name:");
            string firstName = Console.ReadLine();

            Console.Write("Insert last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Insert department: ");
            string department = Console.ReadLine();

            Console.Write("insert gender (m/f)");
            string genderString = Console.ReadLine();
        }
        private static Gender ConvertToGender(string genderString)
        {

        }
    }
}

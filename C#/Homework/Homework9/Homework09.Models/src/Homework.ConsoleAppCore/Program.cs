using Homework09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.ConsoleApp
{
    class Program
    {
        private static List<Manager> managers = new List<Manager>();
        private static Manager selectedManager;
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
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
                Console.WriteLine("------------------");
                if (CreateNewManager())
                {
                    Console.WriteLine("Successfully created manager");
                    Console.WriteLine("Press enter to continue.");
                }
                Console.ReadLine();
                return true;
            }
            else if (result == "2")
            {
                Console.WriteLine("--------------------");
                bool displayManagersMenu = true;
                while (displayManagersMenu)
                {
                    displayManagersMenu = ManagersMenu();
                }
                return true;
            }
            else if (result == "0")
            {
                return false;
            }
            else
                return true;
        }
        private static bool CreateNewManager()
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

            Gender gender = ConvertToGender(genderString);

            Console.Write("Insert salary: ");
            double salary = double.Parse(Console.ReadLine());

            if (AlreadyExistManagerForDepartment(department))
            {
                Console.WriteLine("Already exist manager for {0} department", department);
                return false;
            }
            managers.Add(new Manager(id, firstName, lastName, gender, department, salary));
            return true;
        }
        private static bool CreateNewSalesPerson()
        {
            Console.WriteLine("Create new sales person");

            Console.Write("Insert first name:");
            string firstName = Console.ReadLine();

            Console.Write("Insert last name: ");
            string lastName = Console.ReadLine();

            Console.Write("insert gender (m/f)");
            string genderString = Console.ReadLine();

            Gender gender = ConvertToGender(genderString);

            selectedManager.SalesPersons.Add(new SalesPerson(firstName, lastName, gender));
            return true;
        }
        private static bool ManagersMenu()
        {
            Console.Clear();
            if (managers.Count == 0)
            {
                Console.WriteLine("There are no managers");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                return false;
            }
            Console.WriteLine("Please select a manager");
            foreach (var manager in managers)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", manager.Id, manager.FirstName, manager.LastName));
            }
            Console.WriteLine("Select 0 to go back");
            int selectedNumber = int.Parse(Console.ReadLine());

            if (selectedNumber == 0)
            {
                return false;
            }
            if (managers.Any(manager => manager.Id == selectedNumber))
            {
                selectedManager = managers.FirstOrDefault(manager => manager.Id == selectedNumber);
                bool displayManagersOptions = true;
                while (displayManagersOptions)
                {
                    displayManagersOptions = ManagersOptionsMenu();
                }
            }
            return true;
        }
        private static bool ManagersOptionsMenu()
        {
            Console.Clear();
            Console.WriteLine("Managers menu");
            Console.WriteLine("Choose option");
            Console.WriteLine(" 1) Add new Sales Person");
            Console.WriteLine(" 2) Print manager's details");
            Console.WriteLine(" 3) Print sales persons ordered by first name");
            Console.WriteLine(" 4) Print sales persons - only female");
            Console.WriteLine(" 0) Back");

            string result = Console.ReadLine();

            switch (result)
            {
                case "1":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Add new sales person");
                    if (CreateNewSalesPerson())
                    {
                        Console.WriteLine("Successfully created Sales person");
                        Console.WriteLine("Press enter to continue");
                    }
                    Console.ReadLine();
                    return true;
                case "2":
                    Console.WriteLine("------------------");
                    Console.WriteLine("Manager details: ");
                    selectedManager.PrintInfo();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return true;
                case "3":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Print sales persons - ordered by first name");
                    selectedManager.PrintSalesPersonsOrderedByFirstName();
                    return true;
                case "4":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Print all female sales persons");
                    selectedManager.PrintSalesPersonsOrderedByGender();
                    return true;
                case "0":
                    Console.WriteLine("------------------");
                    Console.WriteLine("Confirm exit by pressing enter");
                    Console.ReadLine();
                    selectedManager = null;
                    return false;
                default:
                    return true;
            }
        }
        private static bool AlreadyExistManagerForDepartment(string department)
        {
            return managers.Any(manager => manager.Department.ToLower() == department.ToLower());
        }
        private static Gender ConvertToGender(string genderString)
        {
            Gender gender = Gender.Female;

            if (genderString.ToLower() == "m")
            {
                gender = Gender.Male;
            }
            else if (genderString.ToLower() == "f")
            {
                gender = Gender.Female;
            }
            return gender;
        }
    }
}

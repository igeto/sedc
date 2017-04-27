using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework09.Models
{
    public class Manager : Employee
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public List<SalesPerson> SalesPersons { get; set; }

        public Manager(int id, string firstName, string lastName, Gender gender, string department, double salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = Gender;
            Department = department;
            Salary = salary;
            SalesPersons = new List<SalesPerson>();  
        }
        public override void PrintInfo()
        {
            Console.WriteLine(string.Format("{0} {1} ({2}) is a manager on {3} department with Salary {4}", FirstName, LastName, Gender, Department, Salary));
        }
        public void PrintSalesPersonsOrderedByFirstName()
        {
            Console.WriteLine("Sales persons: ");
            if (!SalesPersons.Any())
            {
                Console.WriteLine("There are no sales persons");
            }
            else
            {
                foreach (var salesPerson in SalesPersons.OrderBy(sp => sp.FirstName))
                {
                    salesPerson.PrintInfo();
                }
            }
        }
        public void PrintSalesPersonsOrderedByGender()
        {
            Console.WriteLine("Sales persons: ");
            if (!SalesPersons.Any())
            {
                Console.WriteLine("There are no sales persons");
            }
            else
            {
                foreach (var salesPerson in SalesPersons.Where(sp => sp.Gender == Gender.Female).OrderBy(sp => sp.FirstName))
                {
                    salesPerson.PrintInfo();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise.Employees
{

    public class Manager : Employee
    {
        public string Department { get; set; }
        private double Bonus { get; set; }
        public Manager(string firstName, string lastName, string department, double salary) : base(firstName, lastName)
        {
            Department = department;
            FirstName = firstName;
            Salary = salary;
            //LastName = lastName;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }
        public void AddBonus()
        {
            Console.Write("Enter ammount of bonus: ");
            double bonus = double.Parse(Console.ReadLine());
            Bonus = bonus;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Manager of {0} department\nFirst Name: {1}\nLast Name: {2}\nSalary: {3:C}", Department, FirstName, LastName, GetSalary());
        }
    }
}

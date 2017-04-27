using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework09.Models
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public Gender Gender { get; set; }

        public virtual double GetSalary()
        {
            return Salary;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("First Name: {0}, Last Name: {1}, Gender: {2}, Salary: {3}", FirstName, LastName, Gender, GetSalary());
        }
    }
}

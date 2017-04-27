using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework09.Models
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Salary = 500;
        }
    }
}

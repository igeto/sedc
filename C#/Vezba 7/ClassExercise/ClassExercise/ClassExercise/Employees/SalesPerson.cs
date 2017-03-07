using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise.Employees
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 500;
        }

        public void AddRevenue(double revenue)
        {
            SuccessSaleRevenue += revenue;
        }
        private double CalculateAnnualBonus()
        {
            double AnnualBonus;
            if (SuccessSaleRevenue <= 0)
            {
                return 0;
            }
            if (SuccessSaleRevenue <= 2000)
            {
                AnnualBonus = 500;
            }
            else if (SuccessSaleRevenue <= 5000)
            {
                AnnualBonus = 800;
            }
            else
            {
                AnnualBonus = 2000;
            }
            return AnnualBonus;
        }
        public override double GetSalary()
        {
            return base.GetSalary() + CalculateAnnualBonus();
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Sales Agent:\nFirst Name: {0}\nLast Name: {1}\nSalary: {2:C}", FirstName, LastName, GetSalary());
        }
    }
}

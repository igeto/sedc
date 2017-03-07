using ClassExercise.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager igor = new Manager("Igor", "Mitkovski", "Finance", 7500);
            SalesPerson dejan = new SalesPerson("Dejan", "Ivkovski");
            //dejan.AddRevenue(2600);
            Console.WriteLine("{0:C}", dejan.GetSalary());
            dejan.PrintInfo();
            igor.AddBonus();
            igor.PrintInfo();
            Console.ReadLine();
        }
    }
}

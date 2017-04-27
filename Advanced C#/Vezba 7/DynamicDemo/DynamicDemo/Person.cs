using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}

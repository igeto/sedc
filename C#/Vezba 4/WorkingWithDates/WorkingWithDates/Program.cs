using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDateTime = DateTime.Now;

            Console.WriteLine(myDateTime);
            Console.WriteLine(myDateTime.AddDays(5));
            Console.WriteLine(myDateTime.ToShortTimeString());
            DateTime birthday = new DateTime(1988, 10, 19);
            int age = myDateTime.Year - birthday.Year;
            Console.WriteLine(age);
            Console.ReadLine();
        }
    }
}

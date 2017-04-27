using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic eden = 1;
            int dva = 1;
            if (eden.GetType() == dva.GetType())
            {
                Console.WriteLine("IT LIVES!!");
            }
            dynamic person = new Person();
            person.FirstName = "Igor";
            Console.WriteLine(person.FirstName);
            Console.ReadLine();
        }
    }
}

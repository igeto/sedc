using System;
using Static.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape.Name = "Igor Igeto Mitkovski";
            Console.WriteLine(Shape.GetShapeName());

            Console.WriteLine(Calculator.Sum(5, 8));
            Console.WriteLine(Calculator.SquareRoot(9));

            Console.ReadLine();
        }
    }
}

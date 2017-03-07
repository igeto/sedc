using InhertianceAbstract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Models.Square();
            square.Name = "Square 1";
            square.SideLength = 3;
            Console.WriteLine(square.GetValues());
            //Console.WriteLine(square.CalculateDiagonal());
            //Console.WriteLine(square.CalculatePerimeter());

            Rectangle rectangle = new Rectangle();
            rectangle.Name = "Rectangle 1";
            rectangle.SideA = 3;
            rectangle.SideB = 6;
            Console.WriteLine(rectangle.GetValues());

            Console.ReadLine();
        }
        class TestClass : Square
        {

        }
    }
}

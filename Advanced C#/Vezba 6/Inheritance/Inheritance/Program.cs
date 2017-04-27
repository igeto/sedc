using Inheritance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.SideLength = 20;
            square.Name = "Square Name";
            Shape shape = new Shape();
            square.Hello();
            Rectangle rectangle = new Rectangle();
            rectangle.SideA = 5;
            rectangle.SideB = 10;
            rectangle.Name = "Rectangle name";

            Console.WriteLine(square.Name + " " + square.SideLength.ToString());

            Console.ReadLine();
        }
    }
}

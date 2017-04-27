using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int numberTwo = int.Parse(Console.ReadLine());

            try
            {
                double result = numberOne / numberTwo;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}

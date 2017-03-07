using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number to see what you've won: ");
            
            //Console.Read();
            //int a = Convert.ToInt32(Console.ReadLine());
            int firstNumber = int.Parse(Console.ReadLine());
            if (firstNumber == 1)
            {
                Console.WriteLine("Ete raboti");
            }
            else
            {
                Console.WriteLine("so ti e se da ti ebam?");
            }
            Console.ReadLine();
        }
    }
}

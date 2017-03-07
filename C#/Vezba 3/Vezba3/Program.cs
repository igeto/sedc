using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            PrintNumberDescending(n);
            Console.Read();
        }
        static void PrintNumberAscending(int n)
        {
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(i);
            //}
            int i = 1;
            while(i <= n)
            {
                Console.WriteLine(i);
                i++;
            }            
        }
        static void PrintNumberDescending(int n)
        {
            //for (int i = n; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}            
            int i = n;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }
        }
        static void PrintEvenNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void PrintOddNumbers(int n)
        {
            for (int i = 1; i <= n; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        static void BreakForLoop(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("i: " + i);
                if (i == 7)
                {
                    Console.WriteLine("Seven");
                    break;
                }
            }
            Console.WriteLine("End");
        }
    }
}

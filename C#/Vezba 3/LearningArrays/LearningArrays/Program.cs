using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] stringArray = new string[]
            //{
            //    "one",
            //    "two",
            //    "three",
            //    "four"
            //};

            //foreach (var s in stringArray)
            //{
            //    Console.WriteLine(s);
            //}
            ReverseString();
            Console.Read();
        }
        static void ReverseString()
        {
            string fullName = "Igor Igeto Mitkovski";
            char[] charArray = fullName.ToCharArray();

            Array.Reverse(charArray);

            Console.WriteLine("Initial value: " + fullName);
            Console.Write("Reversed value: ");

            foreach (char a in charArray)
            {
                Console.Write(a);
            }

        }
    }
}

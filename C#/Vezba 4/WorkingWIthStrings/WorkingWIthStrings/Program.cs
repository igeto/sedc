using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWIthStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string checkDrive = "We will have \"fair\" elections";
            //string newLine = @"I need a \n line";
            //string world = "World";
            //string helloWorld = string.Format("{0} {1}", "Hello", world);
            //string currency = string.Format("Currency: {0:C}", 123.45);
            //string number = string.Format("Number: {0:N}", 12365456454654);
            //string percent = string.Format("Percent: {0:P}", 1.3);
            //string custom = string.Format("Custom: {0:(###)###-###}", 072276425);
            //Console.WriteLine(custom);
            FunWithStrings();

            Console.ReadLine();
        }
        static void FunWithStrings()
        {
            string sedc = "     Hello from CodeCademy 2017";
            sedc = sedc.ToUpper().Trim();
            Console.WriteLine(sedc);
            string replaced = sedc.Replace(' ', '-');
            Console.WriteLine(replaced);

            Console.WriteLine("Insert character: ");
            string input = Console.ReadLine();

            if (sedc.StartsWith(input))
            {
                Console.WriteLine("U r correct my good sir");
            }
            else
            {
                Console.WriteLine("U r a worthless piece of shit");
            }
            //Console.Write("Enter one digit number: ");
            //int length = int.Parse(Console.ReadLine());
            //string result;
            //if (length > sedc.Length || length < 0)
            //{
            //    Console.WriteLine("U r stupid");
            //}
            //else
            //{
            //    result = sedc.Substring(0, length);
            //    Console.WriteLine(result);
            //}
        }
    }
}

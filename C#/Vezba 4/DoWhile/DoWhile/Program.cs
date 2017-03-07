using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a two or more digit number: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 9)
            //    IncrementByFive(number);
            //else
            //{
            //    Console.Write("Please enter a two or more digit number: ");
            //    number = int.Parse(Console.ReadLine());
            //    IncrementByFive(number);
            //}
            MaxAndMinNumbers();
                Console.ReadLine();
        }
        static void IncrementByFive(int number)
        {
            int i = 0;
            do
            {
                if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= number);
        }
        static void MaxAndMinNumbers()
        {
            Console.Write("Enter the length of the array: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            int i = 0;
            Console.WriteLine("Enter the values of the array (press enter after every input)");
            while (i < arrayLength)
            {
                string inputValue = Console.ReadLine();
                if (int.TryParse(inputValue, out array[i]) == false)
                {
                    Console.WriteLine("The unput is not a number");
                    return;
                }
                i++;
            }
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(array[k] + " ");
            }
            int maxValue = array[0];
            int minValue = maxValue;
            int j = 1;
            while (j < array.Length)
            {
                if (maxValue < array[j])
                {
                    maxValue = array[j];
                }
                if (minValue > array[j])
                {
                    minValue = array[j];
                }
                j++;
            }
            Console.Write("\n");
            Console.WriteLine("The max value in the array is " + maxValue);
            Console.WriteLine("The min value in the array is " + minValue);
        }
    }
}

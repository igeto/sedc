using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTaskFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            int[] evens;
            int[] odds;
            array = FillArray(array);
            evens = EvensOfArray(array);
            odds = OddsOfArray(array);
            DisplayArray(array);
            DisplayReverseArray(array);
            DisplayArray(evens);
            DisplayArray(odds);
            Console.ReadLine();
        }
        static int[] FillArray(int[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter the integer value in the array on position " + i + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void DisplayArray (int[] array)
        {
            Console.WriteLine("The array is:");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                    Console.Write(array[i] + " ");
                else
                    Console.WriteLine(array[i]);
            }
        }
        static void DisplayReverseArray(int[] array)
        {
            Array.Reverse(array);
            DisplayArray(array);
        }
        static int[] EvensOfArray(int[] array)
        {
            List<int> evensList = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evensList.Add(array[i]);
                }
            }
            int[] evens = evensList.ToArray();
            return evens;
        }
        static int[] OddsOfArray(int[] array)
        {
            List<int> oddsList = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddsList.Add(array[i]);
                }
            }
            int[] odds = oddsList.ToArray();
            return odds;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            var word = Console.ReadLine();
            char[] wordToChar = word.ToCharArray();
            string result = string.Empty;
            Stack<char> wordStack = new Stack<char>();

            foreach (var letter in wordToChar)
            {
                wordStack.Push(letter);
            }
            for (int i = 0; i < wordStack.Count();)
            {
                result += wordStack.Pop();
            }
            //foreach (var item in wordStack)
            //{
            //    result += item;
            //}
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

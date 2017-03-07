using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }            
        }
        static bool MainMenu()
        {
            //Start:
            Console.WriteLine("Choose option");
            Console.WriteLine("  1) Print numbers");
            Console.WriteLine("  2) Guess the number");
            Console.WriteLine("  3) Exit");

            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
                //goto Start;
            }
            else if (result == "2")
            {
                GuessTheNumber();
                return true;
                //goto Start;
            }
            else if(result == "3")
            {
                return false;
            }
            else
                return true;
        }
        static void PrintNumbers()
        {
            Console.Clear();
            for (int i = 0; i < 10;  i++)
            {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();
        }
        static void GuessTheNumber()
        {
            Console.Clear();
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int guess = 0;
            int guessLimit = 3;
            bool incorrect = true;
            do
            {
                Console.Write("Guess the number between 1 and 10: ");
                string result = Console.ReadLine();
                guess++;
                if (result == randomNumber.ToString())
                {
                    Console.WriteLine("Bravo, u have guessed the number");
                    incorrect = false;
                }
                else
                {
                    if (guess < guessLimit)
                    {
                        Console.WriteLine("Wrong, you have " + (guessLimit - guess) + " tries left");
                    }
                    if (guess == guessLimit)
                    {
                        Console.WriteLine("You didnt guess the number, but u can try again");
                        incorrect = false;
                    }
                }
            } while (incorrect);
            
        }
    }
}

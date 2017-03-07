using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            double marketValue;

            if (Year > 2000)
            {
                marketValue = 20000;
            }
            else
            {
                marketValue = 10000;
            }
            return marketValue;
        }
        private string MethodTest()
        {
            return "IMA EDNO DETE, PELISTER SE VIKA!!! I SEKOJ DEN NA VARDAR NA GRADSKI MU GO PIKA";
        }
        /// <summary>
        /// I am doing something, unlike you,
        /// you worthless piece of shit
        /// </summary>
        public void DoSomething()
        {
            Console.WriteLine(MethodTest());
        }
    }
}

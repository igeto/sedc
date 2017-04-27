using Macedonia.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macedonia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();

            string breakChar = string.Empty;

            while (breakChar != ";")
            {
                Console.WriteLine("Enter a macedonian city");
                string cityName = Console.ReadLine();
                Console.WriteLine("What is the temperature in that city?");
                string temperature = Console.ReadLine();
                cities.Add(new City()
                {
                    Name = cityName,
                    Temp = Double.Parse(temperature)
                });
                Console.WriteLine("Enter ';' to exit the aplication");
                breakChar = Console.ReadLine(); ;
            }
            MidTemp(cities);
        }
    }
}

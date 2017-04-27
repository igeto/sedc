using Parking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", "320d", "Igor Igeto Mitkovski");
            Car car2 = new Car("BMW", "525d", "Bobo Lazarevski");
            Car car3 = new Car("Opel", "Astra", "Martin Mitushev");
            Vehicle vehicle1 = new Vehicle()
            {
                Make = "Volvo",
                Model = "S60"
            };
            Vehicle vehicle2 = new Vehicle()
            {
                Make = "Fiat",
                Model = "Lupo"
            };
            Vehicle vehicle3 = new Vehicle()
            {
                Make = "Volkswagen",
                Model = "Golf"
            };            
        }

        
    }
}

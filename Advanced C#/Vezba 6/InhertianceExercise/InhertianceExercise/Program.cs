using InhertianceExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "BMW";
            car.Model = "525d";
            car.Year = new DateTime(2000, 10, 10);
            car.Color = "Silver";

            Truck truck = new Models.Truck();
            truck.Make = "Mercedes";
            truck.Model = "Actross";
            truck.Year = new DateTime(1950);
            truck.Color = "Red";
            truck.TowingCapacity = 5;

            Console.WriteLine(car.FormatMe());
            Console.WriteLine(truck.FormatMe());

            Console.ReadLine();
        }
    }
}

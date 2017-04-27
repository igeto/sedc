using HomeworkTaskFive.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTaskFive
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
            Console.WriteLine("===============================================");
            Console.WriteLine("Choose option");
            Console.WriteLine("  1) Create Car");
            Console.WriteLine("  2) Create Truck");
            Console.WriteLine("  3) Exit");
            

            string result = Console.ReadLine();
            if (result == "1")
            {
                CreateCar();
                return true;
                //goto Start;
            }
            else if (result == "2")
            {
                CreateTruck();
                return true;
                //goto Start;
            }
            else if (result == "3")
            {
                return false;
            }
            else
                return true;
        }
        static void CreateCar()
        {
            Console.Clear();
            Console.WriteLine("Please enter the information about the new car");
            Car car = new Car();
            Console.Write("Make: ");
            car.Make = Console.ReadLine();
            Console.Write("Model: ");
            car.Model = Console.ReadLine();
            Console.Write("Color: ");
            car.Color = Console.ReadLine();
            Console.Write("Year: ");
            car.Year = int.Parse(Console.ReadLine());
            Console.WriteLine("License Plate: ");
            string temp = Console.ReadLine();
            car.SetLicensePlate(temp);
            Console.Write("Power: ");
            car.Power = double.Parse(Console.ReadLine());

            car.PrintInfo();
            Console.ReadLine();
        }
        static void CreateTruck()
        {
            Console.Clear();
            Console.WriteLine("Please enter the information about the new truck");
            Truck truck = new Truck();
            Console.Write("Make: ");
            truck.Make = Console.ReadLine();
            Console.Write("Model: ");
            truck.Model = Console.ReadLine();
            Console.Write("Color: ");
            truck.Color = Console.ReadLine();
            Console.Write("Year: ");
            truck.Year = int.Parse(Console.ReadLine());
            Console.WriteLine("License Plate:\n* The licence plate number must be between 7 and 8 characters long");
            string temp = Console.ReadLine();
            truck.SetLicensePlate(temp);
            Console.Write("Power: ");
            truck.Power = double.Parse(Console.ReadLine());
            Console.Write("Capacity in tones: ");
            truck.Capacity = double.Parse(Console.ReadLine());

            truck.PrintInfo();
        }
    }
}

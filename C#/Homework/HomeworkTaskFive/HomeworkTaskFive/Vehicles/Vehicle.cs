using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTaskFive.Vehicles
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        protected string LicensePlate { get; set; }
        public int Year { get; set; }
        public double Power { get; set; }
        
        public void SetLicensePlate()
        {
            Console.WriteLine("* License Plate number must be 7 or 8 characters long");
            string temp = Console.ReadLine();
            string temp2 = temp.Insert(temp.Length - 2, "-");
            LicensePlate = temp2.Insert(2, "-");

            LicensePlate = LicensePlate.ToUpper();
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Power: " + Power + "KW");
            Console.WriteLine("License Plate: " + LicensePlate);
        }
    }
}

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
        
        public void SetLicensePlate(string plateNumber)
        {
            if (plateNumber.Length == 7 || plateNumber.Length == 8)
            {
                LicensePlate = plateNumber.Insert(plateNumber.Length - 2, "-").Insert(2, "-").ToUpper();
            } 
            else
                Console.WriteLine("The licence plate number is not valid.");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine($"Make: {Make}\nModel: {Model}\nColor: {Color}\nYear: {Year}\nPower: {Power}KW\nLicense Plate: {LicensePlate}");
            
        }
    }
}

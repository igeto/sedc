using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTaskFive.Vehicles
{
    class Truck : Vehicle
    {
        public double Capacity { get; set; }
        
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Capacity: {Capacity}t");
        }
    }
}

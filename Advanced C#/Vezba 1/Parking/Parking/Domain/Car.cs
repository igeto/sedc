using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Domain
{
    public class Car : Vehicle
    {
        public string DriverName { get; set; }
        public Car(string make, string model, string driverName)
        {
            Make = make;
            Model = model;
            DriverName = driverName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceExercise.Models
{
    class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }

        public override string FormatMe()
        {
            return "Make: " + Make + " Model: " + Model + " Year: " + Year.Year + " Color: " + Color + " Towing Capacity: " + TowingCapacity + "\n";
        }
    }
}

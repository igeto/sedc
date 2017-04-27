using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public ConditionEnum Condition { get; set; }
    }
    enum ConditionEnum
    {
        Crashed,
        Used,
        New
    }
}

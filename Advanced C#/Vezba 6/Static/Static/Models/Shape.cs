using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Models
{
    public class Shape
    {
        public static string Name { get; set; }
        public static string GetShapeName()
        {
            return Name;
        }
    }
}

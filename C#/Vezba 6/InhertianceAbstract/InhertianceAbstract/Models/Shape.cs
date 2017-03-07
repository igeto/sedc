using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceAbstract.Models
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public abstract double CalculateDiagonal();
        public virtual string GetValues()
        {
            return "Name: " + Name;
        }
    }
}

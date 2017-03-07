using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceAbstract.Models
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public override double CalculateArea()
        {
            return SideA * SideB;
        }

        public override double CalculateDiagonal()
        {
            return Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
        }

        public override double CalculatePerimeter()
        {
            //throw new NotImplementedException();
            return 2 * SideA + 2 * SideB;
        }
        public override string GetValues()
        {
            return string.Format("{3}\nArea: {0}\nPerimeter: {1}\nDiagonal: {2}", CalculateArea(), CalculatePerimeter(), CalculateDiagonal(), base.GetValues());
        }
    }
}

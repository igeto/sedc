using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertianceAbstract.Models
{
    public sealed class Square : Shape
    {
        public double SideLength { get; set; }
        public override double CalculateArea()
        {
            return SideLength * SideLength;
        }

        public override double CalculateDiagonal()
        {
            return Math.Sqrt(2) * SideLength;
        }

        public override double CalculatePerimeter()
        {
            return 4 * SideLength;
        }

        public override string GetValues()
        {
            return string.Format("{3}\nArea: {0}\nPerimeter: {1}\nDiagonal: {2}", CalculateArea(), CalculatePerimeter(), CalculateDiagonal(), base.GetValues());
        }
    }
}

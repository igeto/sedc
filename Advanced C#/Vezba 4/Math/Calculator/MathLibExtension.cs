using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib1;

namespace Calculator
{
   public static class MathLibExtension
    {
        public static double Divide(this MathLib ml, double x, double y)
        {
            return x / y;
        }
    }
}

using Macedonia.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macedonia.Helpers
{
    public static class CityHelper
    {
        public static string MidTemp(List<City> cities)
        {
            double sum = cities.Sum(c => c.Temp);
            double result = sum / cities.Count();
            return result.ToString();
        }
    }
}

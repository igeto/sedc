using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    public class Class1
    {
        private static string k = "";
        static void Main(string[] args)
        {
            int j = 0;
            for (int i = 0; i < 5; i++)
            {
                j = i;
                k = i.ToString();
            }
            Console.WriteLine(j);
            HelperMethod();
        }
        static void HelperMethod()
        {
            Console.WriteLine(k);
        }
    }
}

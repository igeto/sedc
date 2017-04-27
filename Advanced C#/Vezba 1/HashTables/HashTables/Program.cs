using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(3, "three");
            ht.Add(4, "four");
            ht.Add("fv", "five");
            ht.Add(8.5F, 8.5F);
            ht.Add(33, "adasd");

            var strValue1 = ht[2];
            string strValue2 = (string)ht["fv"];
            float fValue = (float)ht[8.5F];
            int strValue3 = (int)ht[2];
            var asdasd = ht[33];

            Console.WriteLine(strValue1.GetType().Name);
            Console.WriteLine(asdasd.GetType());
            Console.WriteLine(fValue);
            Console.WriteLine(strValue3);
            Console.ReadLine();
        }
    }
}

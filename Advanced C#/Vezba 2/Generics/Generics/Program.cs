using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> intArray = new MyGenericArray<int>(6);
            for (int i = 0; i < 6; i++)
            {
                intArray.SetItem(i, i * i);
            }

            MyGenericArray<int> intArrayTwo = new MyGenericArray<int>(6);
            for (int i = 0; i < 6; i++)
            {
                intArrayTwo.SetItem(i, i * i * i);
            }
        }
    }
}

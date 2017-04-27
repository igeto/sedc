using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Interfaces
    {
        interface Interface1
        {
            void method1();
        }
        interface Interface2
        {
            void method1();
        }
        public class Example : Interface1, Interface2
        {
            void Interface1.method1()
            {
                //Implementation 1
            }
            void Interface2.method1()
            {
                //Implementation 2
            }

            public void method1()
            {
                //Default;
            }
        }
    }
}

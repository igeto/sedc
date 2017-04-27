using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new PartialClass.Person();
            person.FirstName = "Igor";
            person.LastName = "Mitkovski";
        }
    }
}

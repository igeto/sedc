using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Human
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        
        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            Lastname = lastName;
        }

        public void GetFullName()
        {
            Console.WriteLine("{0} {1}", FirstName, Lastname);
        }
    }
}

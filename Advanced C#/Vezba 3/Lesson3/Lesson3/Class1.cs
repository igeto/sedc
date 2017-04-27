using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    
    interface ILivingBeing
    {
        string GetSurname();
    }
    interface IHuman : ILivingBeing
    {
        string GetName();
    }
    public class Person : IHuman
    {        
        public string GetName()
        {
            throw new NotImplementedException();
        }

        public string GetSurname()
        {
            throw new NotImplementedException();
        }
        public string SomeMethod() { return " "; }
    }
    public class Program
    {
        public void Main()
        {
            Person person = new Person();
            person.GetName();
            person.GetName();
            person.SomeMethod();

            IHuman person2 = new Person();
            person2.GetName();
            person2.GetSurname();

            ILivingBeing person3 = new Person();
            person3.GetSurname();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;

namespace University
{
    public abstract class Person : IStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int IndexNumber { get; set; }
        public UniversityCard UniversityCard { get; set; }

        public Person(int indexNumber, string firstName, string lastName, UniversityCard universityCard)
        {
            IndexNumber = indexNumber;
            FirstName = firstName;
            LastName = lastName;
            UniversityCard = universityCard;
        }
        
        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

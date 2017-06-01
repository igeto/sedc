using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingWithEntity.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public Student()
        {

        }
        public Student(string firstName, string lastName)
        { 
            FirstName = firstName;
            LastName = lastName;
        }

        
    }
}
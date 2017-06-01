using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewMVCProject.Domain
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
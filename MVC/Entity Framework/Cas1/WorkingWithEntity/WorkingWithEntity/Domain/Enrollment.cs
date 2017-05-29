using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingWithEntity.Domain
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Grade? Grade { get; set; }
        public DateTime EnrolmentDate { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
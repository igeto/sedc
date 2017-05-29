﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingWithEntity.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public Course()
        {

        }
        public Course(int id, string title, int credits)
        {
            Id = id;
            Title = title;
            Credits = credits;
        }
    }
}
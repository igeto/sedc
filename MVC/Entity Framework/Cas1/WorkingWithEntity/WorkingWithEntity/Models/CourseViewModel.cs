﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkingWithEntity.Domain;

namespace WorkingWithEntity.Models
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }        
    }
}
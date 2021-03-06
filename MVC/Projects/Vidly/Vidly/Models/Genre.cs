﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Display(Name = "Genre")]
        public string GenreType { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
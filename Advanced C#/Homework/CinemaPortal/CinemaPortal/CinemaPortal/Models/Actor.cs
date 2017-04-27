using CinemaPortal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPortal.Models
{
    class Actor : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public double Income { get; set; }
        public List<Movie> Movies { get; set; }
        public List<string> TitleAwards { get; set; } //This can be an object in the future
    }
}

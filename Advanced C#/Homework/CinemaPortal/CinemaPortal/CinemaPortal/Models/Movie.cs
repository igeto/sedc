using CinemaPortal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaPortal
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Genre> Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double EarningsFirstWeek { get; set; }
        public int Rank { get; set; }
        public double Rating { get; set; }
    }
}

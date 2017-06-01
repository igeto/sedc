using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class Projection
    {
        public int ProjectionID { get; set; }
        public DateTime Date { get; set; }
        public int MovieID { get; set; }
        public int HallID { get; set; }

        public Movie Movie { get; set; }
        public Hall Hall { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}

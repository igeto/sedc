using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public bool HasAttended { get; set; }
        public int ProjectionID { get; set; }
        public int UserID { get; set; }

        public Projection Projection { get; set; }
        public User User { get; set; }
    }
}

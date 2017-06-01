using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class Hall
    {
        public int HallID { get; set; }
        public string Name { get; set; }
        public int NumberOfSeats { get; set; }
        public virtual ICollection<Projection> Projections { get; set; }
    }
}

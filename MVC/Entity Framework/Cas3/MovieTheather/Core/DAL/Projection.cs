using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class Projection : BaseEntity
    {
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [Display(Name = "Data na proekcija")]
        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("Movie")]
        public int MovieID { get; set; }

        [ForeignKey("Hall")]
        public int HallID { get; set; }

        public Movie Movie { get; set; }
        public Hall Hall { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}

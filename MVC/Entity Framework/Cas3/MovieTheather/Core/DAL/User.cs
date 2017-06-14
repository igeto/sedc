using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class User : BaseEntity
    {
        [Display(Name = "Ime")]
        [StringLength(30, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Display(Name = "Prezime")]
        [StringLength(60, MinimumLength = 2)]
        public string LastName { get; set; }
        public UserType Type { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}

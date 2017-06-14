using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class Hall : BaseEntity
    {
        [Display(Name = "Ime")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Broj na sedista")]
        [Required( ErrorMessage = "Morate da vnesite vrednost" )]
        [Range(10, 100, ErrorMessage = "Vnesete vrednost pomegju 10 i 100")]
        public int NumberOfSeats { get; set; }

        public virtual ICollection<Projection> Projections { get; set; }
    }
}

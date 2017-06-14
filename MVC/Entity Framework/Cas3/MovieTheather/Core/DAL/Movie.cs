using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class Movie : BaseEntity
    {
        [Display(Name = "Ime na film")]
        [Required]
        [StringLength(100, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Vremetraenje")]
        [Required]
        public int Duration { get; set; }

        public ICollection<Projection> Projections{ get; set; }
    }
}

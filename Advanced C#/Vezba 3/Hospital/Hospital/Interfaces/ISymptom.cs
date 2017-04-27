using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Interfaces
{
    interface ISymptom : INameInterface
    {
        string Name { get; set; }
        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }
        string Description { get; set; }
    }
}

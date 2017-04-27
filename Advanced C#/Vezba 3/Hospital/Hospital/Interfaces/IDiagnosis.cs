using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Interfaces
{
    interface IDiagnosis : INameInterface
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}

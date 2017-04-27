using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Interfaces
{
    interface INurse : IHuman, IPayInterface, ITaxInterface
    {
        int Salary { get; set; }
    }
}

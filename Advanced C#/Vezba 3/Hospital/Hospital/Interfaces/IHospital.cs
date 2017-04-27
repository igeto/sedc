using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Interfaces
{
    interface IHospital : IPayInterface, ITaxInterface, INameInterface
    {
        string Name { get; set; }
        double Revenue { get; set; }
        int NumberOfEmployees { get; set; }
        List<IDoctor> Doctors { get; set; }
    }
}

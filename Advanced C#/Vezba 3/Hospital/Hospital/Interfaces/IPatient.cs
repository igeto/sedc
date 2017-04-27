using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Interfaces
{
    interface IPatient : IHuman
    {
        string Illness { get; set; }
        List<ISymptom> Symptoms { get; set; }
    }
}

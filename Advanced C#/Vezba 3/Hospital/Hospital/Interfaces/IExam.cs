using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Interfaces
{
    interface IExam
    {
        DateTime Time { get; set; }
        IDoctor Doctor { get; set; }
        IPatient Patient { get; set; }
        List<ISymptom> Symptoms { get; set; }
        IDiagnosis Diagnosis { get; set; }
    }
}

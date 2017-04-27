using Hospital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{
    class Exam : IExam
    {
        private IDiagnosis _diagnosis;
        public IDiagnosis Diagnosis
        {
            get { return _diagnosis; }
            set { _diagnosis = value; }
        }

        private IDoctor _doctor;

        public IDoctor Doctor
        {
            get { return _doctor; }
            set { _doctor = value; }
        }

        private IPatient _patient;

        public IPatient Patient
        {
            get { return _patient; }
            set { _patient = value; }
        }

        private List<ISymptom> _symptoms;

        public List<ISymptom> Symptoms
        {
            get { return _symptoms; }
            set { _symptoms = value; }
        }

        private DateTime _time;

        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }
    }
}

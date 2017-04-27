using Hospital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{
    class Patient : IPatient
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _illness;

        public string Illness
        {
            get { return _illness; }
            set { _illness = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private List<ISymptom> _symptoms;

        public List<ISymptom> Symptoms
        {
            get { return _symptoms; }
            set { _symptoms = value; }
        }
        public string GetName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}

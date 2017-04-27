using Hospital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{
    class Diagnosis : IDiagnosis
    {
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string GetName()
        {
            return Name;
        }
    }
}

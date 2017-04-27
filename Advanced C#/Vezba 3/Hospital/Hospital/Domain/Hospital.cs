using Hospital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{
    class Hospital : IHospital
    {
        private List<IDoctor> _doctors;

        public List<IDoctor> Doctors
        {
            get { return _doctors; }
            set { _doctors = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _numberOfEmployees;

        public int NumberOfEmployees
        {
            get { return _numberOfEmployees; }
            set { _numberOfEmployees = value; }
        }

        private double _revenue;

        public double Revenue
        {
            get { return _revenue; }
            set { _revenue = value; }
        }
        public string GetName()
        {
            return Name;
        }
        public double PayTax()
        {
            return Revenue * 20 / 100;
        }
        public double Pay()
        {
            return PayTax();
        }
    }
}

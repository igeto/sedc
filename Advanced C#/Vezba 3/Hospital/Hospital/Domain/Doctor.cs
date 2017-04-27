using Hospital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{
    class Doctor : IDoctor
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
            get{
                return _iD;}

            set { _iD = value; }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private int _salary;
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }


        private string _specialty;
        public string Specialty
        {
            get { return _specialty; }
            set { _specialty = value; }
        }
        public string GetName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
        public double PayTax()
        {
            return Salary * 15 / 100;
        }
        public double Pay()
        {
            return PayTax();
        }
    }
}

using Hospital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain
{
    class Nurse : INurse
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
        public string GetName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
        public double PayTax()
        {
            return Salary * 10 / 100;
        }
        public double Pay()
        {
            return PayTax();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Interfaces
{
    interface IDoctor : IHuman, IPayInterface, ITaxInterface
    {        
        string Specialty { get; set; }
        int Salary { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class ParttimeEmployee : Employee

    {
        public int Workinghour { get; set; }
        public override double calSalary()
        {
            return 100000 * Workinghour;
        }
    }
}

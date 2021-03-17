﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    class Toys : Product
    {
        public int AgeLimit { get; private set; }
        public Toys(int agelimit, string name, int calories, bool eatable, string consume) : base(name, calories, eatable, consume)
        {
            AgeLimit = agelimit;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    public class Toys : Product
    {
        public int AgeLimit { get; private set; }
        public Toys(int agelimit, string name, int calories, bool eatable, string consume, int price) : base(name, calories, eatable, consume, price)
        {
            AgeLimit = agelimit;
        }

        public new string ToString()
        {
            return base.ToString() + $"Age limit: {this.AgeLimit}";
        }
    }
}


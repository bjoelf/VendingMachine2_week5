using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    public class Toys : Product
    {
        public int AgeLimit { get; private set; }
        public Toys(int agelimit, string name, int calories, bool eatable, string description, string usage, int price) : base(name, calories, eatable, description, usage, price)
        {
            AgeLimit = agelimit;
        }

        public new string Examine()
        {
            return $"{Description}. Not recommended below age: {AgeLimit}. Price is: {Price}";
        }
        public new string Use()
        {
            string use = (this.Eatable) ? "Delicious!" : "Not for consumtion";
            return $"{Description} {use}";
        }
    }
}
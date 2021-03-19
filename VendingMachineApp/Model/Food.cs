using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    public class Food : Product
    {
        public string Cuisine { get; private set; }
        public Food(string cuisine, string name, int calories, bool eatable, string description, string usage, int price) : base(name, calories, eatable, description, usage, price)
        {
            Cuisine = cuisine;
        }

        public new string Examine()
        {
                return $"Cuisine: {Cuisine} " + base.Examine();
        }
    }
}

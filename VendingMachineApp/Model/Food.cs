using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    public class Food : Product
    {
        public string Cuisine { get; private set; }
        public Food(string cuisine, string name, int calories, bool eatable, string consume, int price) : base(name, calories, eatable, consume, price)
        {
            Cuisine = cuisine;
        }
        public new string ToString()
        {
            return base.ToString() + $"Cuisine: {this.Cuisine}";
        }
    }
}

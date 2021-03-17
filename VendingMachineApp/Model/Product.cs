using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    public abstract class Product
    {
        public readonly int id;
        public string Name { get; private set; }
        public int Calories { get; private set; }
        public bool Eatable { get; private set; }
        public string Consume { get; private set; }

        public Product(string name, int calories, bool eatable, string consume)
        {
            Name = name;
            Calories = calories;
            Eatable = eatable;
            Consume = consume;
        }
    }
}

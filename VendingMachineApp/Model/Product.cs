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
        public string Description { get; private set; }
        public string Usage { get; private set; }
        public int Price { get; private set; }
        public Product(string name, int calories, bool eatable, string consume, string usage, int price)
        {
            Name = name;
            Calories = calories;
            Eatable = eatable;
            Description = consume;
            Price = price;
            Usage = usage;
        }
        public string Examine()
        {
            return $"{Description}. Price is: {Price}";
        }
        public string Use()
        {
            string use = (this.Eatable) ? "Delicious!":"Not for consumtion.";
            return $"{Usage} {use}";
        }
    }
}
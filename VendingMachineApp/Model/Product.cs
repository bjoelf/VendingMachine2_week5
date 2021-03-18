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
        public int Price { get; private set; }

        public Product(string name, int calories, bool eatable, string consume, int price)
        {
            Name = name;
            Calories = calories;
            Eatable = eatable;
            Consume = consume;
            Price = price;
        }

        public string Examine()
        {
            return $"{Consume} + Price is: {Price}";
        }
        public string Use()
        {
            string use = (this.Eatable) ? "Delicious!":"Not for consumtion";
            return $"{Consume} + Price is: {Price}";
        }

    }
}

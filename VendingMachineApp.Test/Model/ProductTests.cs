using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineApp.Model;
using System.Diagnostics;

namespace VendingMachineApp.Test.Model
{
    public class ProductTests
    {
        [Fact]
        public void AddProductsIntoList()
        {
            List<Product> purchases = new List<Product>();


            Beverages beer = new Beverages(0.055, "Bryggmästarens", 99, true, "Drink it cold", 25);
            purchases.Add(beer);

            Beverages anotherbeer = new Beverages(0.055, "Bryggmästarens", 99, true, "Drink it cold", 25);
            purchases.Add(anotherbeer);

            Food hotdish = new Food("Thai", "Hot Curry", 850, true, "Eat while warm. Drink milk if too hot", 125);
            purchases.Add(hotdish);

            Food dessert = new Food("Italian", "tiramisu", 200, true, "Enjoy this delight with a cappuchino", 30);
            purchases.Add(dessert);

            Beverages coffee = new Beverages(0, "Espresso", 0, true, "Enjoy any time during the day.", 10);
            purchases.Add(coffee);

            Toys rubicscube = new Toys(5, "Rubic's cube", 0, false, "Twist and turn in enternity", 40);
            purchases.Add(rubicscube);

            Assert.NotNull(beer);
            Assert.Equal(6, purchases.Count);
        }
    }
}
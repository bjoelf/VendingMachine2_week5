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

            Beverages beer = new Beverages(0.055, "Bryggmästarens", 99, true, "Bryggmästarens Premium gold är ett exklusivt öl framtaget med förstklassiga råvaror", "Drink it cold", 25);
            purchases.Add(beer);

            //test idential product
            purchases.Add(beer);

            Food hotdish = new Food("Thai", "Tom Yum Goong", 275, true, "This iconic bowl of steaming goodness is bold, aromatic and comes with a fairly strong spicy kick", "Eat it with spoon and a fork", 125); ;
            purchases.Add(hotdish);

            Food dessert = new Food("Italian", "tiramisu", 200, true, "Classic italian dessert", "Enjoy this delight with a cappuchino", 30);
            purchases.Add(dessert);

            Beverages coffee = new Beverages(0, "Espresso", 0, true, "Black italian coffee with crema on top", "Enjoy any time during the day.", 10);
            purchases.Add(coffee);

            Toys rubicscube = new Toys(5, "Rubic's cube", 0, false, "Rubik's Cube is a 3D combination puzzle invented in 1974 by Hungarian sculptor and professor of architecture Ernő Rubik", "Twist and turn in enternity", 40);
            purchases.Add(rubicscube);

            Assert.NotNull(beer);
            Assert.Equal(6, purchases.Count);
        }
    }
}
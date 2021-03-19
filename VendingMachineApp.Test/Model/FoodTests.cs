using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineApp.Model;
using System.Diagnostics;

namespace VendingMachineApp.Test.Model
{
    public class FoodTests
    {
        [Fact]
        public void ExamineAndUse()
        {
            Food thaifood = new Food("Thai", "Tom Yum Goong", 275, true, "This iconic bowl of steaming goodness is bold, aromatic and comes with a fairly strong spicy kick","Eat it with spoon and a fork.", 125); ;
            Debug.Print(thaifood.Examine());
            Debug.Print(thaifood.Use());

            Food pizza = new Food("Italian", "Pizza Margherita", 350, true, "A typical Neapolitan pizza, made with San Marzano tomatoes, mozzarella cheese, fresh basil, salt and extra-virgin olive oil","Slice it with and have one slice at a time." ,20);
            Debug.Print(pizza.Examine());
            Debug.Print(pizza.Use());

            Assert.NotEqual(pizza.Use().Length, pizza.Examine().Length);
            Assert.NotEqual(thaifood.Use().Length, thaifood.Examine().Length);
        }
    }
}

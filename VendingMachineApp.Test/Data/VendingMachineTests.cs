using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineApp.Data;
using VendingMachineApp.Model;
using System.Diagnostics;

namespace VendingMachineApp.Test.Data
{
    public class VendingMachineTests
    {
        [Fact]
        public void InsertMoney()
        {
            VendingMachine vm = new VendingMachine();
            int[] sumCredit = vm.EndTransaction();

            vm.InsertMoney(100);
            Assert.Equal(100, vm.Credit);

            vm.InsertMoney(99);
            Assert.Equal(100, vm.Credit);

            vm.InsertMoney(100);
            Assert.Equal(200, vm.Credit);
        }
        [Fact]
        public void ShowAll()
        {
            VendingMachine vm = new VendingMachine();
            int[] sumCredit = vm.EndTransaction();

            vm.InsertMoney(1000);

            Beverages beer = new Beverages(0.055, "Bryggmästarens", 99, true, "Drink it cold", 25);
            vm.Purchase(beer);
            vm.Purchase(beer);

            Food hotdish = new Food("Thai", "Hot Curry", 850, true, "Eat while warm. Drink milk if too hot", 125);
            vm.Purchase(hotdish);

            Food dessert = new Food("Italian", "tiramisu", 200, true, "Enjoy this delight with a cappuchino", 30);
            vm.Purchase(dessert);

            Beverages coffee = new Beverages(0, "Espresso", 0, true, "Enjoy any time during the day.", 10);
            vm.Purchase(coffee);

            Toys rubicscube = new Toys(5, "Rubic's cube", 0, false, "Twist and turn in enternity", 40);
            vm.Purchase(rubicscube);

            //foreach (Product item in vm.ShowAll())
            //{
            //    if (item is Toys)
            //    {

            //    }
            //    else // food or beverage
            //    {
            //        if (item is Beverages)
            //    }
            //}

                //Debug.Print()
            
        }
        [Fact]
        public void PurchaseAndShowAll()
        {
            VendingMachine vm = new VendingMachine();
            int[] sumCredit = vm.EndTransaction();

            vm.InsertMoney(1000);

            Beverages beer = new Beverages(0.055, "Bryggmästarens", 99, true, "Drink it cold", 25);
            vm.Purchase(beer);
            vm.Purchase(beer);

            Food hotdish = new Food("Thai", "Hot Curry", 850, true, "Eat while warm. Drink milk if too hot", 125);
            vm.Purchase(hotdish);

            Food dessert = new Food("Italian", "tiramisu", 200, true, "Enjoy this delight with a cappuchino", 30);
            vm.Purchase(dessert);

            Beverages coffee = new Beverages(0, "Espresso", 0, true, "Enjoy any time during the day.", 10);
            vm.Purchase(coffee);

            Toys rubicscube = new Toys(5, "Rubic's cube", 0, false, "Twist and turn in enternity", 40);
            vm.Purchase(rubicscube);
        }
        [Fact]
        public void EndTransaction()
        {

        }
    }
}

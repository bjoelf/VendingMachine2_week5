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

            Beverages beer = new Beverages(0.055, "Bryggmästarens", 99, true, "Bryggmästarens Premium gold är ett exklusivt öl framtaget med förstklassiga råvaror", "Drink it cold", 25);
            vm.Purchase(beer);
            vm.Purchase(beer);

            Food hotdish = new Food("Thai", "Hot Curry", 850, true, "Hot thai soup","Eat while warm. Drink milk if too hot", 125);
            vm.Purchase(hotdish);

            Food dessert = new Food("Italian", "tiramisu", 200, true, "Classical italian dessert","Enjoy this delight with a cappuchino", 30);
            vm.Purchase(dessert);

            Beverages coffee = new Beverages(0, "Espresso", 0, true,"Black strong coffee", "Enjoy any time during the day.", 10);
            vm.Purchase(coffee);

            Toys rubicscube = new Toys(5, "Rubic's cube", 0, false, "Needs no explanaion","Twist and turn in enternity", 40);
            vm.Purchase(rubicscube);

            foreach (Product item in vm.ShowAll())
            {
                Debug.Print(item.Examine());
            }
            Debug.Print("-------------------------------");
            foreach (Product item in vm.ShowAll())
            {
                Debug.Print(item.Use());
            }

            Assert.Equal(6, vm.ShowAll().Count);
        }
        [Fact]
        public void ShowBeverages()
        {
            VendingMachine vm = new VendingMachine();
            int[] sumCredit = vm.EndTransaction();
            vm.InsertMoney(1000);

            Beverages beer = new Beverages(0.055, "Bryggmästarens", 99, true, "Bryggmästarens Premium gold är ett exklusivt öl framtaget med förstklassiga råvaror", "Drink it cold", 25);
            vm.Purchase(beer);
            vm.Purchase(beer);

            Food hotdish = new Food("Thai", "Hot Curry", 850, true, "Hot thai soup", "Eat while warm. Drink milk if too hot", 125);
            vm.Purchase(hotdish);

            Food dessert = new Food("Italian", "tiramisu", 200, true, "Classical italian dessert", "Enjoy this delight with a cappuchino", 30);
            vm.Purchase(dessert);

            Beverages coffee = new Beverages(0, "Espresso", 0, true, "Black strong coffee", "Enjoy any time during the day.", 10);
            vm.Purchase(coffee);

            Toys rubicscube = new Toys(5, "Rubic's cube", 0, false, "Needs no explanaion", "Twist and turn in enternity", 40);
            vm.Purchase(rubicscube);

            foreach (Product item in vm.ShowAll(beer))
            {
                Debug.Print(item.Examine());
            }

            Assert.Equal(3, vm.ShowAll(beer).Count);
        }
        [Fact]
        public void Purchase()
        {
            VendingMachine vm = new VendingMachine();
            int[] sumCredit = vm.EndTransaction();

            vm.InsertMoney(1000);

            Beverages beer = new Beverages(0.055, "Bryggmästarens", 99, true, "Bryggmästarens Premium gold är ett exklusivt öl framtaget med förstklassiga råvaror", "Drink it cold", 25);
            vm.Purchase(beer);
            vm.Purchase(beer);

            Food hotdish = new Food("Thai", "Hot Curry", 850, true, "Traditional thai dish","Eat while warm. Drink milk if too hot", 125);
            vm.Purchase(hotdish);

            Food dessert = new Food("Italian", "tiramisu", 200, true,"Classic italian dessert" ,"Enjoy this delight with a cappuchino", 30);
            vm.Purchase(dessert);

            Beverages coffee = new Beverages(0, "Espresso", 0, true,"Black italian coffee with crema on top" ,"Enjoy any time during the day.", 10);
            vm.Purchase(coffee);

            Toys rubicscube = new Toys(5, "Rubic's cube", 0, false, "Rubik's Cube is a 3D combination puzzle invented in 1974 by Hungarian sculptor and professor of architecture Ernő Rubik", "Twist and turn in enternity", 40);
            vm.Purchase(rubicscube);

            Assert.Equal(6, vm.ShowAll().Count);
        }
        [Fact]
        public void EndTransaction()
        {
            VendingMachine vm = new VendingMachine();
            int[] sumCredit = vm.EndTransaction();
            vm.InsertMoney(1000);

            Food hotdish = new Food("Thai", "Hot Curry", 850, true, "Traditional thai dish", "Eat while warm. Drink milk if too hot", 125);
            vm.Purchase(hotdish);

            Food dessert = new Food("Italian", "tiramisu", 200, true, "Classic italian dessert", "Enjoy this delight with a cappuchino", 30);
            vm.Purchase(dessert);

            sumCredit = vm.EndTransaction();

            int sum = 0;
            foreach (int item in sumCredit)
            {
                sum += item;
            }
            Assert.Equal(845, sum);
        }
    }
}

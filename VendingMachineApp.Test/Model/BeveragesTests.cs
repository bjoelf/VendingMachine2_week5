using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineApp.Model;
using System.Diagnostics;

namespace VendingMachineApp.Test.Model
{
    public class BeveragesTests
    {
        [Fact]
        public void ExamineAndUse()
        {
            Beverages beer = new Beverages(0.055, "Bryggmästarens Guld", 99, true, "Bryggmästarens Premium gold är ett exklusivt öl framtaget med förstklassiga råvaror", "Drink it cold", 25);
            Debug.Print(beer.Examine());
            Debug.Print(beer.Use());

            Beverages soda = new Beverages(0.0, "Coca Cola", 50, true, "The Coca-Cola company's flagship product", "Drink it cold with fiends or alone.", 20);
            Debug.Print(soda.Examine());
            Debug.Print(soda.Use());
        }
    }
}

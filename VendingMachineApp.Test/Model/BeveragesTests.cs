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
        public void Examine()
        {

            Beverages beer = new Beverages(0.055, "Bryggmästarens", 99, true, "Drink it cold", 25);
            string exam = beer.Examine();
            Debug.Print(exam);

            Assert.True(true);
        }
        [Fact]
        public void Use()
        {

        }

    }
}

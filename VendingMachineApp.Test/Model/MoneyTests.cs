using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineApp.Model;
using Xunit;

namespace VendingMachineApp.Test.Model
{
    public class MoneyTests
    {
        [Fact]
        public void Exist()
        {
            Money m = new Money();

            bool _exists = Money.Exist(100);
            Assert.True(_exists);

            _exists = Money.Exist(159);
            Assert.False(_exists);

            _exists = Money.Exist(1);
            Assert.True(_exists);

            _exists = Money.Exist(0);
            Assert.False(_exists);
        }
    }
}
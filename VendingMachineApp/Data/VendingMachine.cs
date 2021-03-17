using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineApp.Model;

namespace VendingMachineApp.Data
{
    public class VendingMachine : IVending
    {
        private static int sumCredit;
        private static List<Product> purchases;

        public int[] EndTransaction()
        {
            int payout = sumCredit;
            sumCredit = 0;
            int[] change = Money.GiveChange(payout);
            return change;
        }
        public int InsertMoney(int amount)
        {
            if (Money.Exist(amount))
            {
                sumCredit += amount;
            }
            return sumCredit;
        }
        public string Purchase(Product product)
        {
            purchases.Add(product);
            return product.Consume;
        }
        public List<Product> ShowAll()
        {
            return purchases;
        }
    }
}

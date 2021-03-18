using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineApp.Model;

namespace VendingMachineApp.Data
{
    public class VendingMachine : IVending
    {
        //private static int sumCredit;
        private static List<Product> purchases = new List<Product>();
        private static int credit = 0;
        private Money m = new Money();

        public int Credit { get { return credit;  } }

        public int[] EndTransaction()
        {
            int payout = Credit;
            credit = 0;
            int[] change = Money.GiveChange(payout);
            return change;
        }
        public int InsertMoney(int amount)
        {
            if (Money.Exist(amount))
            {
                credit += amount;
            }
            return Credit;
        }
        public Product Purchase(Product product)
        {
            if (product.Price <= Credit)
            {
                purchases.Add(product);
                return product;
            }
            else
            {
                return null;
            }
        }
        public List<Product> ShowAll()
        {
            return purchases;
        }
    }
}

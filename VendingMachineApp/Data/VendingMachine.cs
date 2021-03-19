using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineApp.Model;

namespace VendingMachineApp.Data
{
    public class VendingMachine : IVending
    {
        private static List<Product> purchases = new List<Product>();
        private static int credit = 0;
        private readonly Money money = new Money();

        public int Credit { get { return credit;  } }
        public int[] EndTransaction()
        {
            int payout = Credit;
            int[] change = Money.GiveChange(payout);
            credit = 0;
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
                credit -= product.Price;
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
        public List<Beverages> ShowAllBeverages()
        {
            List<Beverages> bev = new List<Beverages>();

            foreach (Product prod in purchases)
            {
                if (prod is Beverages)
                {
                    bev.Add(prod as Beverages);
                }
            }
            return bev;
        }
        public List<Food> ShowAllFood()
        {
            List<Food> eat = new List<Food>();

            foreach (Product prod in purchases)
            {
                if (prod is Food)
                {
                    eat.Add(prod as Food);
                }
            }
            return eat;
        }
    }
}

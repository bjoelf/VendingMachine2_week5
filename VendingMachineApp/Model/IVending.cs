using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    public interface IVending
    {
        public Product Purchase(Product product);
        public List<Product> ShowAll();
        public int InsertMoney(int amount);
        public int[] EndTransaction();
    }
}

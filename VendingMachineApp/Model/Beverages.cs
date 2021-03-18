using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    public class Beverages : Product
    {
        public double AlcoholContent { get; private set; }
        public Beverages(double alcoholcontent, string name, int calories, bool eatable, string consume, int price) : base(name,calories,eatable,consume, price)
        {
            AlcoholContent = alcoholcontent;
        }
        public new string ToString()
        {
            if (this.AlcoholContent == 0)
            {
                return base.ToString();
            }
            else
            {
                return base.ToString() + $" Not for kids. Alcohol content: {AlcoholContent} ";
            }
        }
    }
}

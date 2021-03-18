using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    public class Beverages : Product
    {
        public double AlcoholContent { get; private set; }
        public Beverages(double alcoholcontent, string name, int calories, bool eatable, string description,string usage, int price) : base(name,calories,eatable, description, usage, price)
        {
            AlcoholContent = alcoholcontent;
        }

        public new string Examine()
        {
            if (this.AlcoholContent > 0)
            {
                return base.Examine() + $" Not for kids. Alcohol content: {AlcoholContent}";
            }
            else
            {
                return base.Examine();
            }
        }

        public new string Use()
        {
            string use = (this.Eatable) ? "Delicious!" : "Not for consumtion";
            return $"{Description} + Price is: {Price}";
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

using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{
    public class Beverages : Product
    {
        public decimal AlcoholContent { get; private set; }
        public Beverages(decimal alcoholcontent, string name, int calories, bool eatable, string consume) : base(name,calories,eatable,consume)
        {
            AlcoholContent = alcoholcontent;
        }
    }
}

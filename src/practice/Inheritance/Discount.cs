using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Discount
    {
        public double Amount { get; set; } //auto property
        //constructor 
        public Discount(double amount)
        {
            Amount = amount;
        }

        //Method
        //"virtual add for method override"
        public virtual double PriceAfterDiscount(double originalPrice) 
        {
            return originalPrice - Amount;
        }

    }
}

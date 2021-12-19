using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Discount
    {
        public Discount(double amount)
        {
            Amount = amount;
        }
        public double Amount { get; set; }
        public abstract double PriceAfterDiscount(double originalPrice);
        //overload method
        public abstract double PriceAfterDiscount(double originalPrice,  string s);
    }
}

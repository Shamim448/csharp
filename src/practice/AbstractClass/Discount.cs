using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Discount : IDiscount
    {
       
        public double Amount { get; set; }
        public Discount(double amount)
        {
            // Amount = amount;
        }
        public abstract double PriceAfterDiscount(double originalPrice);
        //overload method
        public abstract double PriceAfterDiscount(double originalPrice,  string s);
    }
}

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

        //Method
        public double PriceAfterDiscount(double originalPrice) 
        {
            return originalPrice - Amount;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class DixedAmountDiscount: Discount 
    {
        public DixedAmountDiscount():base(0){

            }
        public override double PriceAfterDiscount(double originalPrice)
        {
            return originalPrice-Amount;
        }

        public override double PriceAfterDiscount(double originalPrice, string s )
        {
            return originalPrice - (originalPrice*Amount/100);
        }
    }
}

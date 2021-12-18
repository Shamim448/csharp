using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Inherited class
    public class PercentageDiscount : Discount
    {
        //"Override: use for over write main method from discount class
        public override double PriceAfterDiscount(double originalPrice)
        {
            return originalPrice - (originalPrice * Amount / 100.0);
        }
    }
}

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
        public PercentageDiscount(int amount) : base(amount)
            {
            Console.WriteLine("Chield Constractor");
        }
        public override int priceAfterDiscount(int originalPrice)
        {
            return originalPrice - ((originalPrice * Amout) /100);
        }
    }
}

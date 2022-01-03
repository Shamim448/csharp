using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revise_Of_Abstract_Class
{
    internal class ChildClass:AabstractClass
    {
        public override double PriceAfterDiscount(double originalprice)
        {
            return originalprice-DiscountAmount;
        }
    }
}

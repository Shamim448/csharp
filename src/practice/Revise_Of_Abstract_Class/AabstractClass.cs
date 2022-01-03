using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revise_Of_Abstract_Class
{
    internal abstract class AabstractClass
    {
        public int DiscountAmount { get; set; }
        public abstract double PriceAfterDiscount(double originalprice);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revise_Of_Abstract_Class
{
    internal interface IDiscount
    {
        public abstract int DiscountAmount { get; set; }
        public abstract double PriceAfterDiscount(double originalprice);

    }
}

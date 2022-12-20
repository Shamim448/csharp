using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PertialClass
{
    internal partial class Product
    {
      public string Name { get; set; }
      public string Description { get; set; }
      public double Amount { get; set; }
      public double PriceAfterDiscount(int discoutPrice)
        {
            return Amount - discoutPrice;
        }
    }
}
 
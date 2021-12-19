using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public interface IDiscount
    {
        double Amount { get; set; }
        double PriceAfterDiscount(double origibalPrice);

    }
}

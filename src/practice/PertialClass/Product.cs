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
        public double Price { get; set; }
        public double CalculatrDiscount(double discountPercentage)
        {
            return (Price * discountPercentage / 100);
        }
    }
}
 
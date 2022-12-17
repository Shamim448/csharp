using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Discount
    {
        public Discount() {
            Console.WriteLine("Parent Constractor");
           
        }
        public int Amout { get; set; }
        public virtual int priceAfterDiscount(int originalPrice)
        {
            return originalPrice - Amout;
        }
       
    }
}

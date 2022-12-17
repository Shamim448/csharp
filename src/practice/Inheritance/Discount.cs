using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Discount
    {
        public  Discount(int amount) {
            Console.WriteLine("Parent Constractor");
            Amout = amount;
           
        }
        public int Amout { get; set; }
        public virtual int priceAfterDiscount(int originalPrice)
        {
            return originalPrice - Amout;
        }
       
    }
}

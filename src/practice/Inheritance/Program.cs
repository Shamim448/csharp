
using System;

namespace Inheritance 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent class
            Discount d = new Discount();
            d.Amout = 10;
            double result = d.priceAfterDiscount(120);
            Console.WriteLine(result);

            //Child class result
            PercentageDiscount p = new PercentageDiscount();
            p.Amout = 10;
            double myResult = p.priceAfterDiscount(120);
            Console.WriteLine(myResult);
        }
    }
}


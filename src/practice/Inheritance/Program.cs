
using System;

namespace Inheritance 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent class
            Discount d = new Discount(10);
            //d.Amout = 10;
            double result = d.priceAfterDiscount(120);
            Console.WriteLine(result);

            //Child class result
            PercentageDiscount p = new PercentageDiscount(12);
            //p.Amout = 10;
            double myResult = p.priceAfterDiscount(120);
            Console.WriteLine(myResult);

            //Example for polymorphism
            Discount poly = new PercentageDiscount(15); //create instance Disscount through child class
            Console.WriteLine(poly.priceAfterDiscount(120));
            //poly.test(); //poly do not find test method because it deckear child classes

            


        }
    }
}


// See https://aka.ms/new-console-template for more information

using Inheritance;
//calculate result from method override from inherited class
PercentageDiscount percentageDiscount = new PercentageDiscount(10);
 //percentageDiscount.Amount = 10;
var priceAfterDiscount = percentageDiscount.PriceAfterDiscount(2000);
Console.WriteLine(priceAfterDiscount);

//Calculate result from Discount class
 Discount discount = new Discount(20);
//discount.Amount = 100;
var afterDiscount = discount.PriceAfterDiscount(2000);
Console.WriteLine(afterDiscount);

//polymorphism
Discount polymorphisms = new PercentageDiscount(10);
var poly = polymorphisms.PriceAfterDiscount(2000);
 //polymorphisms.test(0) not fount bcz test methid nor available in parent class
Console.WriteLine(poly);

// var practice
var x = 5;
var name = "shamim";
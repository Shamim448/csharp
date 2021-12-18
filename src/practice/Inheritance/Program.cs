// See https://aka.ms/new-console-template for more information

using Inheritance;
//calculate result from method override from inherited class
PercentageDiscount percentageDiscount = new PercentageDiscount();
percentageDiscount.Amount = 10;
double priceAfterDiscount = percentageDiscount.PriceAfterDiscount(2000);
Console.WriteLine(priceAfterDiscount);

//Calculate result from Discount class
 Discount discount = new Discount();
discount.Amount = 100;
double afterDiscount = discount.PriceAfterDiscount(1000);
Console.WriteLine(afterDiscount);
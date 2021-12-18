// See https://aka.ms/new-console-template for more information

using Inheritance;
PercentageDiscount percentageDiscount = new PercentageDiscount();
percentageDiscount.Amount = 100;
double priceAfterDiscount = percentageDiscount.PriceAfterDiscount(2000);
Console.WriteLine(priceAfterDiscount);

     
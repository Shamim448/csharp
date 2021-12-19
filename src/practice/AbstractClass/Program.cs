// See https://aka.ms/new-console-template for more information
using AbstractClass;
Discount discount = new DixedAmountDiscount();
discount.Amount = 10;
var fixedDiscount = discount.PriceAfterDiscount(1500);
var percentageDiscount = discount.PriceAfterDiscount(1500, "per");
Console.WriteLine(fixedDiscount);
Console.WriteLine(percentageDiscount);


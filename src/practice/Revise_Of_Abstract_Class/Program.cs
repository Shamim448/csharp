// See https://aka.ms/new-console-template for more information
using Revise_Of_Abstract_Class;
ChildClass childClass = new ChildClass();
childClass.DiscountAmount = 500;
var rate = childClass.PriceAfterDiscount(25150);
Console.WriteLine(rate);

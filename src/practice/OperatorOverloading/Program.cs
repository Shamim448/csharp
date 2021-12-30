// See https://aka.ms/new-console-template for more information
using OperatorOverloading;
int x = +5;
int y = -5;
int z = x + y;

Fraction fraction1 = new Fraction(5, 7);
Fraction fraction2 = new Fraction(3, 4);

Fraction result = fraction1 / fraction2;

Console.WriteLine(result.num + "/"+ result.den);



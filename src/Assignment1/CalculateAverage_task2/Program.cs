// See https://aka.ms/new-console-template for more information

using CalculateAverage_task2;
var averageOfTwoNumber = Calculator.CalculateAverage(2, 5);
var averageOfThreeNumber = Calculator.CalculateAverage(2, 5, 8);
double[] arra = { 1, 2, 5 };
var averageOfarray = Calculator.CalculateAverage(arra);
Console.WriteLine("\nThe average Of Two Number:" +  averageOfTwoNumber);
Console.WriteLine("\nThe average Of Three Number:" + averageOfThreeNumber);
Console.WriteLine("\nThe average Of the array:" + averageOfarray);


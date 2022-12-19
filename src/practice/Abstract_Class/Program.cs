// See https://aka.ms/new-console-template for more information
using Abstract_Class;

Rectangle r = new Rectangle();
Console.WriteLine("Enter the Length: ");
r.length = double.Parse(Console.ReadLine().Trim());
Console.WriteLine("Enter the width: ");
r.width = double.Parse(Console.ReadLine().Trim());
Console.Write("The Area of Ractangle is: ");
Console.Write(r.area());
Console.ReadLine();
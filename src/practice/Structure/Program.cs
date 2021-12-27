// See https://aka.ms/new-console-template for more information
using Structure;

Point p1 = new Point();
p1.X = 10;
p1.Y = 20;

Point p2 = new Point();
p2.X = 40;
p2.Y = 50;

int distance = p2.Distance(p1);
Console.WriteLine(distance);
p2 = p1;
p2.X = 60;


Console.WriteLine(p1.X);
Console.WriteLine(p2.X);
Console.WriteLine("\n");


//class example copy reference
Test p3 = new Test();
p3.X = 10;
p3.Y = 20;

Test p4 = new Test();
p4.X = 40;
p4.Y = 50;

p4 = p3;
p4.X = 60; // change p4.x but change p3.x also because 
//class copy by reference
Console.WriteLine( p3.X);
Console.WriteLine(p4.X);

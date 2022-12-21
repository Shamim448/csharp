using StructureApp;

Point p1 = new Point();
p1.X = 20; 
p1.Y = 20;

Point p2 = new Point();
p2.X = 10;
p2.Y = 20;

var distance = p2.Distance(p1);
Console.WriteLine(distance);
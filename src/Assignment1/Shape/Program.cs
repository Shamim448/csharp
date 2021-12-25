// See https://aka.ms/new-console-template for more information
using Shapes;
Circle circle = new (15);
var areaOfCircle = circle.Area(); 
var perimeterOfCircle = circle.Periameter();
Console.WriteLine("\nThe radius of circle is: {0} \nThe Area of circle is: {1} " +
    "\nThe Perimeter of circle is: {2}", circle.Radius, areaOfCircle, perimeterOfCircle);

Triangle triangle = new Triangle(10, 15);
var areaOfTriangle = triangle.Area();
Console.WriteLine("\nThe width of triangle is: {0} \nThe height of triangle is: {1} " +
    "\nThe Area of triangle is: {2}", triangle.Base, triangle.Height, areaOfTriangle);

Square square = new(10);
var areaOfSquare = square.Area();
var perimeterOfSquare = square.Periameter();
Console.WriteLine("\nThe Side of square is: {0} \nThe Area of square is: {1} " +
    "\nThe Perimeter of square is: {2}", square.Side, areaOfSquare, perimeterOfSquare);
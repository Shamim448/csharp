// See https://aka.ms/new-console-template for more information
using Shapes;
Circle circle = new (15);
var areaOfCircle = circle.Area(); 
Console.WriteLine("\nThe radius of circle is: {0} \nThe Area of circle is: {1}", 
    circle.Radius, areaOfCircle);

Triangle triangle = new Triangle(10, 15);
var areaOfTriangle = triangle.Area();
Console.WriteLine("\nThe width of triangle is: {0} \nThe height of triangle is: {1} " +
    "\nThe Area of triangle is: {2}", triangle.Width, triangle.Height, areaOfTriangle);
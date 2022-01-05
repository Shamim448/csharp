// See https://aka.ms/new-console-template for more information
using Generic;

GenericPoint<int> p2 = new GenericPoint<int>();
p2.X = 5;
p2.Y = 5;
int k = p2.X + p2.Y;
//i assign multiple type data type just create instance
//Thos is the one kind of benifit using Generic
GenericPoint <double> p3 = new GenericPoint<double>();
p3.X = 10.5;
p3.Y = 6.3;
double L = p3.X + p3.Y;

Console.WriteLine(k);
Console.WriteLine(L);

//Object data type
Point p = new Point();
p.X = 5; 
p.Y = 20.6;

//need set type casting because object data type
//int z = (int)p.X + (int)p.Y;
Console.WriteLine(p.Y);


Console.WriteLine("--------List--------");
//Example List Data structure
List<int> myList = new List<int>();
myList.Add(5);
myList.Add(6);
myList.Add(8);
var counts = myList.Count();
Console.WriteLine(counts);
Console.WriteLine(myList[0]);
foreach (int i in myList)
{
    Console.WriteLine(i);
}
        
Console.WriteLine("--------LinkedList--------");
LinkedList<int> list = new LinkedList<int>();
list.AddFirst(5);
Console.WriteLine("--------Dictionary--------");
Dictionary<string, double> grade = new Dictionary<string, double>();
grade.Add("shamim", 4.88);





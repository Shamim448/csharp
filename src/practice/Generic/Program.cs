// See https://aka.ms/new-console-template for more information
using Generic;
using System.Collections;
using System.Text;

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

Console.WriteLine("--------Arraylist--------");
//we can store multiple type data in generic
ArrayList arraylist = new ArrayList();
arraylist.Add(5);
arraylist.Add(L);

Console.WriteLine("--------Generic Constrain--------");
GenericWithConstrain<StringBuilder, int> test = new GenericWithConstrain<StringBuilder, int>();

Console.WriteLine("--------Generic Constrain example--------");
Box<Item> newBook = new Box<Item>();
newBook.Add(new Book() { Name = "C# Complete Refarence", Price = 1800 });
newBook.Add(new Book() { Name = "Tech Yourself C# ", Price = 1900 });
newBook.Add(new Book() { Name = "C# Begeiner Guide", Price = 1000 });
newBook.Add(new Book() { Name = "C# Complete Refarence", Price = 1800 });


Box<Item> newShirt = new Box<Item>();
newShirt.Add(new Shirt() { Name = "Polo", Color = "Red" });
newShirt.Add(new Shirt() { Name = "Ledis Tang Top", Color = "Black" });
//Item can read if arrat was public
//Console.WriteLine(newBook._item[0].Name);

// read data from array by method

Book book = (Book)newBook.Get(2);
Console.WriteLine(book.Name);
Console.WriteLine(book.Price);
//NewBook item clear
newBook.Clear();



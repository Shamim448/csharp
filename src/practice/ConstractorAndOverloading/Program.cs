// See https://aka.ms/new-console-template for more information
using ConstractorAndOverloading;

Line l = new Line();
l.setLenght(16.5);
Console.WriteLine("Length the Line : {0}", l.getLength());

//call paramiterized constractor double type
Line p = new Line(10.6);

// call constractor overloading in type
Line O = new Line(19);

// outpur depends type of input values


Console.ReadLine();

// output
//Print Object line is created from constractor
// Print Length the line 16.5 from method.
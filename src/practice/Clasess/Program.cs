using System;
using Clasess; // use for active Student class
Teachar teachar1 = new Teachar(); //need to add using namespace
Teachar teachar2 = new Teachar();
//Over-write clasess default value
//teachar1.age = 20;
//teachar1.name = "Shamim";
Console.WriteLine(teachar1.age);
Console.WriteLine(teachar1.name);
// Collect value from default
Console.WriteLine(teachar2.age);
Console.WriteLine(teachar2.name);

teachar1.GenerateNewId();
teachar2.GenerateNewId("2000");
Console.WriteLine(teachar1.Id);

//teachar2.Id = "T-1202555";
Console.WriteLine(teachar2.Id);

teachar1.DateOfBirth = new DateTime (1993,01,20);
Console.WriteLine(teachar1.DateOfBirth);

//teachar1.id = "2025515554"; //not found for private
teachar1.address = "Dhaka";
//student doesn't support bcz namespace doesen't add
Student myStudent = new Student();
Clasess.Student mystudent = new Clasess.Student(); 





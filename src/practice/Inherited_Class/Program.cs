// See https://aka.ms/new-console-template for more information
using Clasess;
using InheritedClass;
Console.WriteLine("Hello, World!");

Teachar myteachar = new Teachar();
myteachar.name = "Shamim Hosen";
myteachar.age = 20; // Not fount bcz age was internal variable
myteachar.address = "dhaka";
myteachar.getAddress();

headmaster headMaster = new headmaster();
headMaster.getaddress();
//both namespace add thats way put namespace before class name
InheritedClass.Student newStudent = new InheritedClass.Student();
newStudent.name = "shamim";
newStudent.Id = 20; // not found bcz Id field/property not a inherited student class 
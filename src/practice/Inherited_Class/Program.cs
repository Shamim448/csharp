// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Teachar myteachar = new Teachar();
myteachar.name = "Shamim Hosen";
myteachar.age = 20; // Not fount bcz age was internal variable
myteachar.address = "dhaka";
myteachar.getAddress();

HeadMaster headmaster = new HeadMaster();
headmaster.getAddress(); //found from inheritance class


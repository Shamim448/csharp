using System;


Teachar teachar1 = new Teachar();
Teachar teachar2 = new Teachar();
//Over-write clasess default value
teachar1.age = 20;
teachar1.name = "Shamim";
Console.WriteLine(teachar1.age);
Console.WriteLine(teachar1.name);
// Collect value from default
Console.WriteLine(teachar2.age);
Console.WriteLine(teachar2.name);

teachar1.GenerateNewId();
teachar2.GenerateNewId();
Console.WriteLine(teachar1.Id);

teachar2.Id = "T-1202555";
Console.WriteLine(teachar2.Id);


//teachar1.id = "2025515554"; //not found for private
teachar1.address = "Dhaka";




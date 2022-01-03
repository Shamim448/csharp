// See https://aka.ms/new-console-template for more information
using Property_of_Class;
Property property = new Property();
property.Name = "Shamim";
property.name = "Shohaib";
 Console.WriteLine(property.Name+ " " + property.name);

//overloading
Console.WriteLine("------------Overloading--------------");
Overloading overloading = new Overloading();
overloading.BrandName = "Samsung";
overloading.Model = "A52";
overloading.GetPhoneInfo("G91");
overloading.GetPhoneInfo("768", "32GB");//ovelload
Console.WriteLine("\n Brandname = {0} \n Model = {1} \n Processor = {2} \n Price = {3}",
   overloading.BrandName, overloading.Model, overloading.Processor, overloading.Price);
Console.WriteLine("------------Contructor Overloading--------------");
Overloading overloading1 = new Overloading(25000, "Bronze");
Console.WriteLine(overloading1.Price + " " + overloading1.Color);

Console.WriteLine("------------Contructor Overriding--------------");
Inheritance inheritance = new Inheritance();
inheritance.GetPhoneInfo("Octa-Core", "64 GB");
inheritance.BrandName = "Apple";
Console.WriteLine(inheritance.Processor);//privious 778 after overridding octacore
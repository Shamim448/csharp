using Buildin_Interface;

Pepole people = new Pepole(3);
people.Add(new Person { Name = "Shamim" });
people.Add(new Person { Name = "Saba" });
people.Add(new Person { Name = "Shohaib" });
foreach(var person in people)
{
    Console.WriteLine(person.Name);
}

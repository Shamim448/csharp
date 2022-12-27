using Buildin_Interface;

Pepole people = new Pepole(3);
people.Add(new Person { Name = "Shamim" });
people.Add(new Person { Name = "Saba" });
people.Add(new Person { Name = "Shohaib" });
foreach(var person in people)
{
    Console.WriteLine(person.Name);
}
people.Clear();
people.Add(new Person { Name = "Apple" });
people.Add(new Person { Name = "Shamim" });
people.Add(new Person { Name = "Saba" });
foreach (var person in people)
{
    Console.WriteLine("After clear : {0}", person.Name);
    Person p = (Person)person.Clone();
    Console.WriteLine(p.Name);
}
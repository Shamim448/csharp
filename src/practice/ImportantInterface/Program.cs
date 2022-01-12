// See https://aka.ms/new-console-template for more information
using ImportantInterface;

People people = new People(4);
people.Add(new Person{ Name = "Jalaludin"});
people.Add(new Person { Name = "Shamim" });
people.Add(new Person { Name = "Hosen" });
people.Add(new Person { Name = "Kakon" });


foreach (Person person in people)
{
Console.WriteLine(person.Name);
}
//contains match
var found = people.Contains(new Person { Name = "Hosen" });
if (found)
{
    Console.WriteLine(" Yes found Your Name ");
}
//Remove
people.Remove(new Person { Name = "Hosen" });
foreach (Person person in people)
{
    Console.WriteLine(person.Name);
}
people.Clear();
//After clear
people.Add(new Person { Name = "Hosen" });
people.Add(new Person { Name = "Kakon" });
foreach (Person person in people)
{
    Console.WriteLine(person.Name);
}
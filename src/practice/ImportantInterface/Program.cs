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
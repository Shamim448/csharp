using ImportantInterfaceForExam;
People newpeople = new People(3);
newpeople.Add(new Person { Name = "Shamim"});
newpeople.Add(new Person { Name = "Saba" });
newpeople.Add(new Person { Name = "Shopna" });
foreach (var person in newpeople)
{
    Console.WriteLine(person.Name);
}

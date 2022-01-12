using GenericReviceForExam;
PhoneNumberList<Person> phonenumberlist = new PhoneNumberList<Person>();
phonenumberlist.Add( new Person() { Name = "Shamim", Number = 01746902499 });
phonenumberlist.Add(new Person() { Name = "Fatema", Number = 01786911093 });
phonenumberlist.Add(new Person() { Name = "Alim", Number = 01723130450 });
phonenumberlist.Add(new Person() { Name = "Saba", Number = 01746902499 });

foreach(Person person in phonenumberlist._phoneNumbers)
{
    Console.WriteLine(person.Name);
}

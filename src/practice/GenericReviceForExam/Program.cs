using GenericReviceForExam;
PhoneNumberList<Person> phonenumberlist = new PhoneNumberList<Person>();
phonenumberlist.Add( new Person() { Name = "Shamim", Number = 01746902499 });
phonenumberlist.Add(new Person() { Name = "Fatema", Number = 01786911093 });
phonenumberlist.Add(new Person() { Name = "Alim", Number = 01723130450 });
phonenumberlist.Add(new Person() { Name = "Saba", Number = 01746902499 });

foreach(Person person in phonenumberlist._phoneNumbers)
{
    //Console.WriteLine(person.Name);
}


//GenericMethods genmethod = new GenericMethods();

int[] nums = { 1, 2, 3 };
int[] nums2 = new int[4];
// Display contents of nums.
Console.Write("Contents of nums: ");
foreach (int x in nums)
    Console.Write(x + " ");
Console.WriteLine();
// Operate on an int array.
GenericMethods.CopyInsert(99, 2, nums, nums2);
// Display contents of nums2.
Console.Write("Contents of nums2: ");
foreach (int x in nums2)
    Console.Write(x + " ");
Console.WriteLine();


// Now, use copyInsert on an array of strings.
string[] strs = { "Generics", "are", "powerful." };
string[] strs2 = new string[4];
// Display contents of strs.
Console.Write("Contents of strs: ");
foreach (string s in strs)
    Console.Write(s + " ");
Console.WriteLine();
// Insert into a string array.
GenericMethods.CopyInsert("in C#", 1, strs, strs2);
// Display contents of strs2.
Console.Write("Contents of strs2: ");
foreach (string s in strs2)
    Console.Write(s + " ");
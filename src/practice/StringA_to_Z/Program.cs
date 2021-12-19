// See https://aka.ms/new-console-template for more information

string str = "Hello, World!";
Console.WriteLine(str);
Console.WriteLine(str.Length);
Console.WriteLine(str.ToLower());
//Concatention
string firstName = "Jhon";
string lastName = "Doe";
Console.WriteLine(firstName+ " " + lastName); //Output Jhon Doe
Console.WriteLine(string.Concat(firstName, lastName));  //Output JhonDoe
Console.WriteLine(string.Concat(firstName, " ", lastName));  //Output Jhon Doe
Console.WriteLine("My Full Name Is: " + firstName + " " + lastName);
//Interpolation altanative of concatenation
Console.WriteLine($"My Full Name Is: {firstName} {lastName}");

//We can access charecter in a string by index number
string name = "Shamim Hosen";
Console.WriteLine(name[0]); //index start with 0
Console.WriteLine(name.IndexOf("H"));
//Return a new string from index 7
Console.WriteLine(name.Substring(7)); //Output Hosen
//slice string start index, end index
Console.WriteLine( name.Substring(1, name.Length-2) ); //Output hamim Hose
Console.WriteLine(name.Substring(1, 5));

//string type check
string name1 = "Shamim";
int len = name1.Length;
Console.WriteLine(len);
string name2 = new string("Shamim");
Console.WriteLine(name1 == name2);
Console.WriteLine(name1.GetType());


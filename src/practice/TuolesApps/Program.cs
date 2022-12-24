using TuolesApps;

Membership newMember = new Membership();
var result = newMember.CreateUser("Shamim", "Shohaib44*");
Console.WriteLine(result.Status);
Console.WriteLine(result.User.Username);
Console.WriteLine(result.Item2.Password);

//Tuples is one kind of data type they car recive multiple valu with multiple type at a time
(double x, string y, int z) something;
something.x = 10.65; something.y = "Test"; something.z = 44;
Console.WriteLine(something);


using AdonetCRUD;
string connectionstring = "Server=DESKTOP-DP23GAJ\\SQLEXPRESS;Database=CSharpB9;User Id=shamim;Password=saba2005;";
//string query = "INSERT INTO Students ([Name], DateOfBrith) values ('Shamim Hosen', '1993-01-10')";
string name = Console.ReadLine();
string dateOfBrith = Console.ReadLine();
string query = "INSERT INTO Students ([Name], DateOfBrith) values (@name, @dateOfBrith)";
List<(string key, object value)> paramiters = new List<(string key, object value)>();
paramiters.Add(("name", name));
paramiters.Add(("dateOfBrith", dateOfBrith));
DataUtility datautility = new DataUtility(connectionstring);
datautility.ExecuteCommend(query, paramiters);
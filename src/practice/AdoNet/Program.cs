using AdoNet;
using System.Reflection.PortableExecutable;

string connectionString = "Server = IT-SHAMIM\\SQLEXPRESS; Database = CSharpB9; User Id = Shamim; Password = saba2005";
string name = Console.ReadLine();
string dateOfBirth = Console.ReadLine();
List<(string key, object value)> parameter = new List<(string key, object value)>();
parameter.Add(("name", name));
parameter.Add(("dateOfBirth", dateOfBirth));
string query = $"INSERT INTO Students (Name, DateOfBirth) values (@name, @dateOfBirth)";

DataUtility dataUtility = new(connectionString);
//dataUtility.ExecuteQuery(query, parameter);

string read = "Select * from Students";
var result = dataUtility.ReadData(read);
if(result != null && result.Count > 0) { 
    foreach(var header in result[0].Keys)
    {
        Console.Write(header);
        Console.Write('\t');
    }
    Console.WriteLine();
    foreach (var item in result)
    {
        foreach(var col in item.Values)
        {
            Console.Write(col);
            Console.Write('\t');
        }
        Console.WriteLine();
    }
}
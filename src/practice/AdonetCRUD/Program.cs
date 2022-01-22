
using AdonetCRUD;
string connectionstring = "Server=DESKTOP-7T438A0\\SQLEXPRESS;Database=CSharpB9;User Id=shamim;Password=saba2005;";
//string query = "INSERT INTO Students ([Name], DateOfBrith) values ('Shamim Hosen', '1993-01-10')";
/*
string name = Console.ReadLine();
string dateOfBrith = Console.ReadLine();
string query = "INSERT INTO Students ([Name], DateOfBrith) values (@n, @dob)";
List<(string key, object value)> paramiters = new List<(string key, object value)>();
paramiters.Add(("name", name));
paramiters.Add(("dateOfBrith", dateOfBrith));
DataUtility datautility = new DataUtility(connectionstring);
datautility.ExecuteCommend(query, paramiters);
*/

//Data read

DataUtility dataUtility = new DataUtility(connectionstring);
string query2 = "select * from students";
var result = dataUtility.ReadData(query2, null);


if (result != null && result.Count > 0)
{
    foreach (var col in result[0].Keys)
    {
        Console.Write(col);
        Console.Write('\t');
    }
    Console.WriteLine();

    foreach (var row in result)
    {
        foreach (var col in row.Values)
        {
            Console.Write(col);
            Console.Write('\t');
        }
        Console.WriteLine();
    }
}

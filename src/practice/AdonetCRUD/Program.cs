
using AdonetCRUD;
string connectionstring = "Server=DESKTOP-DP23GAJ\\SQLEXPRESS;Database=CSharpB9;User Id=shamim;Password=saba2005;";
//string query = "INSERT INTO Students ([Name], DateOfBrith) values ('Shamim Hosen', '1993-01-10')";

/*string name = Console.ReadLine();
=======
/*
string name = Console.ReadLine();
>>>>>>> 0a3f69dcc28d1db54f9f29e0cbbc859f50868da8
string dateOfBrith = Console.ReadLine();
string query = "INSERT INTO Students ([Name], DateOfBrith) values (@name, @dateOfBrith)";
List<(string key, object value)> paramiters = new List<(string key, object value)>();
paramiters.Add(("name", name));
paramiters.Add(("dateOfBrith", dateOfBrith));
DataUtility datautility = new DataUtility(connectionstring);
<<<<<<< HEAD
datautility.ExecuteCommend(query, paramiters);*/

//read data
DataUtility datautility = new DataUtility(connectionstring);
string selectQuery = "SELECT * FROM Students";
var result = datautility.DataReader(selectQuery, null);
if( result != null && result.Count > 0)
{
    foreach (var col in result[0].Keys)
    {
        Console.Write(col + '\t');
    }
    Console.WriteLine();
    foreach(var row in result)
    {
        foreach(var col in row.Values)

        {
            Console.Write(col);
            Console.Write('\t');
        }
        Console.WriteLine();


    }
}

    


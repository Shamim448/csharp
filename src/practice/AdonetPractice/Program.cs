using AdonetPractice;

var connectionstring = "Server=.\\SQLEXPRESS; Database = CSharpB9; User Id = csharpb9; Password = 123456;";
/*
Console.WriteLine("Enter Medicin Name");
string? MedicineName = Console.ReadLine();
Console.WriteLine("Enter Quantity");
string? Quantity = Console.ReadLine();
Console.WriteLine("Enter Price");
string? Price = Console.ReadLine();
Console.WriteLine("Enter Date");
string? PurchaseDate = Console.ReadLine();
var query = "INSERT INTO Medicine ([Medicine_Name], Quantity, Price, Purchase_Date) values(@MedicineName, @Quantity, @Price, @PurchaseDate)";

DataUtility dataUtility = new DataUtility(connectionstring);

List <(string key, object values)> paramiters = new List<(string key, object values)>();
paramiters.Add(("MedicineName", MedicineName));
paramiters.Add(("Quantity", Quantity));
paramiters.Add(("Price", Price));
paramiters.Add(("PurchaseDate", PurchaseDate));

dataUtility.ExecuteQuery(query, paramiters);
*/

DataUtility dataUtility = new DataUtility(connectionstring);
var query = "SELECT * FROM Medicine";
var result = dataUtility.ReadData(query, null);
if(result != null && result.Count > 0)
{
    foreach (var col in result[0].Keys)
    {
        Console.Write(col+'\t');
    }
    Console.WriteLine();
    foreach (var row in result)
    {
        foreach(var col in row.Values)
        {
            Console.Write(col);
            Console.Write('\t'+"     " );
            
        }
        Console.WriteLine();

    }
}
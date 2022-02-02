using AdonetPractice;

var connectionstring = "Server=.\\SQLEXPRESS; Database = CSharpB9; User Id = csharpb9; Password = 123456;";
Console.WriteLine("Enter Medicin Name");
string MedicineName = Console.ReadLine();
Console.WriteLine("Enter Quantity");
string Quantity = Console.ReadLine();
Console.WriteLine("Enter Price");
string Price = Console.ReadLine();
Console.WriteLine("Enter Date");
string PurchaseDate = Console.ReadLine();
var query = "INSERT INTO Medicine ([Medicine_Name], Quantity, Price, Purchase_Date) values(@MedicineName, @Quantity, @Price, @PurchaseDate)";

DataUtility dataUtility = new DataUtility(connectionstring);

List <(string key, object values)> paramiters = new List<(string key, object values)>();
paramiters.Add(("MedicineName", MedicineName));
paramiters.Add(("Quantity", Quantity));
paramiters.Add(("Price", Price));
paramiters.Add(("PurchaseDate", PurchaseDate));

dataUtility.ExecuteQuery(query, paramiters);

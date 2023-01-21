
List<int> col = new List<int>() { 20, 29, 50, 38, 26, 64, 24, 88, 75 };
var val = from i in col where i > 20 orderby i select i;
foreach(var item in val)
{
    Console.WriteLine(item);
}
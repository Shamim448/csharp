List<string> names = new List<string> { "Shamim", "Saba", "Sopna", "Kakon", "Fatema", "Rahim", "kabir" };
//Normal Shorting
foreach (string name in names)
{
   if(name.StartsWith('S'))
   Console.WriteLine( name);
}
//quaryable short
Console.WriteLine("***Quaryable short*****");
string[] names2 = (from c in names
                   where c.StartsWith('S')
                   orderby c
                   select c).ToArray();
foreach (string name in names2)
{
    Console.WriteLine( name);
}
//lamda method short
Console.WriteLine("***sort using lamda method*****");
string[] names3 = names.Where(c => c.StartsWith('S')).OrderBy(e => e).ToArray();
foreach (string name in names3)
{
    Console.WriteLine(name);
}

// See https://aka.ms/new-console-template for more information
using ParameterModifier;

Paramiter_Modifier paramiterModifier = new();
var result = paramiterModifier.Sum(5, 3);
var results = paramiterModifier.Sum(5, 3, 5);
var resultArray = paramiterModifier.Sum(new int[] {2, 5, 6, 8});
paramiterModifier.UseParam(new object[] { 1, 'a', "shamim", 5.5 });
Console.WriteLine(result);
Console.WriteLine(results);
Console.WriteLine("params parameter modifier" + resultArray);

//ref parameter modifier

var x = 5;
var y = 6;
Console.WriteLine(x); //normally x = 5
paramiterModifier.Parametr_ref(ref x);

Console.WriteLine("Ref parameter modifier" + x); //after ref x = 10
//because ref in referance type
//in
paramiterModifier.Parametr_in(in y);
Console.WriteLine("In parameter modifier" + y);
//out 
paramiterModifier.Parametr_out(out y);
Console.WriteLine("Out parameter modifier" + y);


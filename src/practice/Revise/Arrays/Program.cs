// See https://aka.ms/new-console-template for more information

//One Dimentional Array

string[] name = new string[] { "Shamim", "Kakon", "Hasan", "Saddam", "habib" };

foreach (string nameItem in name)
{
    Console.WriteLine(nameItem);
    
}
Console.WriteLine("------------");
string[] name1 = { "Shamim", "Kakon", "Hasan", "Saddam", "habib" };
//we can copy whole array
string[] name2 = name1;

foreach (string nameItem in name2)
{
    Console.WriteLine(nameItem);
    
}
//string a = Console.ReadLine(); //input 12:30 PM

//string[] clock = a.Split(" "); // separate 12:30 and pm

Console.WriteLine("-------------Multi Dimentional Array----------------------");

//5 row and 2 column array
int[,] num = new int[5, 2] { { 0, 1 }, { 1, 2 }, { 2, 3 }, { 3, 4 }, { 4, 5 } };
int i, j;
for (i = 0; i < 5; i++)
{
    for (j = 0; j < 2; j++)
    {
        
        Console.WriteLine("num[{0}, {1}] = {2}", i, j, num[i, j]);
    }
}
Console.WriteLine(num.Length); //10
Console.WriteLine(num.GetLength(0)); //5

Console.WriteLine("-------------Jagged array Array----------------------");
//Declaring jagged array
int[][] scores = new int[3][];
for (int k = 0; k <scores.Length; k++)
{
    scores[k] = new int[4];
}
//another initialization
scores[0] = new int[] {3, 5, 8};
scores[1] = new int[] { 4, 6 };
scores[2] = new int[] {};//empty array

Console.WriteLine(scores[0][1]); //5


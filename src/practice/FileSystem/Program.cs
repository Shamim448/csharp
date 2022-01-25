// See https://aka.ms/new-console-template for more information
using System.IO;
string rootPath = @"I:\FileSystem";
/*//read all folder and subfolder
//string [] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
//read only root folder
string[] dirs = Directory.GetDirectories(rootPath);
foreach (string dir in dirs)
{
    Console.WriteLine(dir);
}*/
//File read 

var files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
foreach (var file in files)
{
    Console.WriteLine(file);   
}
Console.WriteLine("\n ******Print File Name Only******");
foreach (var file in files)
{
   Console.WriteLine(Path.GetFileName(file));
}
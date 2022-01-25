// See https://aka.ms/new-console-template for more information
using System.IO;
string rootPath = @"D:\FileSystem";
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
string filename = rootPath + @"\Hello.txt";
if (!File.Exists(filename))
{
    File.Create(filename);
}

using FileStream stream = File.Open(filename, FileMode.Open);
byte[] buffer = System.Text.Encoding.UTF8.GetBytes("My name is shamim");
stream.Write(buffer);
stream.Flush();
stream.Close();

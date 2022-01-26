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
if (File.Exists(filename))
{
    File.Delete(filename);
}
using FileStream createfile = File.Create(filename);
createfile.Dispose();

using FileStream stream = File.Open(filename, FileMode.Open);
byte[] buffer = System.Text.Encoding.UTF8.GetBytes("My name is shamim");
stream.Write(buffer);
stream.Flush();
stream.Close();
//read all text
string read = File.ReadAllText(filename);
Console.WriteLine(read);
stream.Dispose();

//fileinfo this is same to file
FileInfo fileinfo = new FileInfo(filename);
if (fileinfo.Exists)
{
    using FileStream streaminfo = fileinfo.Open(FileMode.Open);
    long size = fileinfo.Length;
    for (long i =0; i < size; i++)
    {
        byte[] buffers = new byte[1];
        int reads = streaminfo.Read(buffers);
        string s = System.Text.Encoding.UTF8.GetString(buffers);
        Console.Write(s);
    }
}


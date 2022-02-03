// See https://aka.ms/new-console-template for more information
var path = "../../../Hello.txt";
if (File.Exists(path))
{
    File.Delete(path);
}
/*File.Create(path);
var path1 = "../../../Test.txt";
using FileStream stream = File.Open(path1, FileMode.Create);
byte[] buffer = System.Text.Encoding.UTF8.GetBytes("Hello World");
stream.Write(buffer);
stream.Flush(); 
stream.Close();
stream.Dispose();
-*/
var path1 = "../../../Test.txt";
FileInfo FileInfo = new FileInfo(path1);
if (FileInfo.Exists)
{
    using FileStream streams = FileInfo.Open(FileMode.Open);
    long size = streams.Length;
    for(int i = 0; i < size; i++)
    {
        byte[] buffers = new byte[1];
        streams.Read(buffers);
        string s = System.Text.Encoding.UTF8.GetString(buffers);
        Console.Write(s);
    }
    streams.Dispose();
    FileInfo.Delete();
}
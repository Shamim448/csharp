using System.Diagnostics.CodeAnalysis;

string file = "../../../Hello.txt";
//File.Create(file);
if (File.Exists(file))
{
    File.Delete(file);
    using FileStream myFile = File.Create(file);
}
//Write File
using FileStream stream = File.Open(file, FileMode.Open);
    byte[] buffer = System.Text.Encoding.UTF8.GetBytes("Hello world");
    stream.Write(buffer);
    stream.Flush();
    stream.Close();
    stream.Dispose();



//Read File using fileinfo object
FileInfo fileInfo = new FileInfo(file);
if (fileInfo.Exists)
{
    using (FileStream streams = fileInfo.Open(FileMode.Open))
    {
        long size = fileInfo.Length;
        for(long i = 0; i < size; i++)
        {
            byte[] buffers = new byte[1];
            streams.Read(buffers);
            string s  = System.Text.Encoding.UTF8.GetString(buffers);
            Console.Write(s);
        }
    }
   // fileInfo.Delete();
}

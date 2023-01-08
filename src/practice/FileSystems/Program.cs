string file = "../../../Hello.txt";
if (File.Exists(file))
{
    File.Delete(file);
    using FileStream myFile = File.Create(file);
}
using FileStream stream = File.Open(file, FileMode.Open);
byte[] buffer = System.Text.Encoding.UTF8.GetBytes("Hello world");
stream.Write(buffer);
stream.Flush();
stream.Close();

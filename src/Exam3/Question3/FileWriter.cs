using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class FileWriter
    {
        //List<string> lines,
        public void WriteToFile( string path)
        {
           if(File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream file = File.Create(path))
            {
                file.Dispose();
                using FileStream stream = File.Open(path, FileMode.Open);
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes("Hello World");

                stream.Write(buffer);
                stream.Flush();
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Exists)
                {
                    using (FileStream stream1 = fileInfo.Open(FileMode.Open))
                    {
                        long size = fileInfo.Length;
                        for (long i = 0; i < size; i++)
                        {
                            byte[] bufferread = new byte[1];
                            int read = stream.Read(buffer);
                            string s = System.Text.Encoding.UTF8.GetString(buffer);
                            Console.WriteLine(s);
                        }
                    }
                    fileInfo.Delete();
                }


            }

        }
    }
}

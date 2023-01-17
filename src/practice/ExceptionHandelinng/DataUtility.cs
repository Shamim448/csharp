using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelinng
{
    internal class DataUtility
    {
        public async Task ReadFile(string path)
        {
            FileStream stream = null;
            try
            {
                stream = File.Open(path, FileMode.Open);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please put the acctual path");
                path = Console.ReadLine();
                stream = File.Open(path, FileMode.Open);
            }
            if(stream != null)
            {
                FileInfo fileInfo = new FileInfo(path);
                for (int i = 0; i < fileInfo.Length; i++)
                {
                    byte[] buffer = new byte[1];
                    stream.ReadAsync(buffer);
                    Console.Write(System.Text.Encoding.UTF8.GetString(buffer));
                }
            }
            
        }
    }
}

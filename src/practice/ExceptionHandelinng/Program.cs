using System;
using System.Text;

namespace ExceptionHandelinng // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DataUtility dataUtility = new DataUtility();
            dataUtility.ReadFile("../../../hello.txt");
        }

       
    }


}
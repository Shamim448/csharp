// See https://aka.ms/new-console-template for more information
using System;

namespace WayTooLongWords_71A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLineNumber = Convert.ToInt32(Console.ReadLine()); //how many line get user inpt
            string[] str = new string[inputLineNumber];
            string temp = string.Empty;
            for (int i = 0; i < inputLineNumber; i++)
            {
                str[i] = Console.ReadLine() .ToLower();

            }
            for (int j = 0; j < str.Length; j++)
            {
                if (10 < str[j].Length)
                {
                    temp = str[j];

                    int len = temp.Length - 2;

                    Console.WriteLine(temp[0] + len.ToString() + temp[temp.Length - 1]);

                }
                else
                {
                    Console.WriteLine(str[j]);
                }
            }
        }
    }
}
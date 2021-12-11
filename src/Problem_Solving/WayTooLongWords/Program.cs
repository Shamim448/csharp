// See https://aka.ms/new-console-template for more information
using System;

namespace WayTooLongWords_71A
{
    internal class Program
    {
        static void Main(string[] args)
        {//how many line get user input
            int inputLineNumber = Convert.ToInt32(Console.ReadLine()); 
            //Array store for user input 
            string[] str = new string[inputLineNumber];
            string temp = string.Empty;
            //user input loop
            for (int i = 0; i < inputLineNumber; i++)
            {
                str[i] = Console.ReadLine() .ToLower();

            }
            //Output process loop
            for (int j = 0; j < str.Length; j++)
            {
                //check lenght
                if (10 < str[j].Length)
                {
                    temp = str[j];

                    int len = temp.Length - 2; //length integer

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
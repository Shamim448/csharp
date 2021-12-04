using System;

namespace BoyOrGirl_236A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().ToLower();
            
                int size = name.Length;
                Char[] checkduplicateletter = name.ToCharArray();
            int count = 0;
            
            for (int i = 0; i < checkduplicateletter.Length; i++)  //5
                {
                    
                    Char ch = checkduplicateletter[i]; //m
                    for (int j = 0; j < i; j++)
                    {

                        if (ch == checkduplicateletter[j])
                        {
                            count++;
                        }

                    }

                if (count == 0)
                {
                    string result = ch.ToString();
                    int resultLength = result.Length;
                    if (resultLength % 2 == 0)
                    {
                        Console.WriteLine("CHAT WITH HER!");
                    }
                    else
                    {
                        Console.WriteLine("IGNORE HIM");
                    }
                }
                break;

            }
            


        }
    }
}

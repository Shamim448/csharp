using System;

namespace BoyOrGirl_236A
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine().ToLower();
            string result = string.Empty;
            for (int i = 0; i < name.Length; i++)
            {
                if (!result.Contains(name[i]))
                {
                    result+=name[i];
                }
                
            }
            //Console.WriteLine(result);
            if(result.Length % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }


        }
    }
}

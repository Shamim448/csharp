using System;

namespace Word_56A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int isLower = 0;
            int isUpper = 0;
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z') //65-91
                {
                    isUpper++;
                }
                else if(str[i] >= 'a' && str[i] <= 'z') //97-122
                {
                    isLower++;
                }
            }
            if (isUpper > isLower)
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                Console.WriteLine(str.ToLower());
            }
        }
    }
}

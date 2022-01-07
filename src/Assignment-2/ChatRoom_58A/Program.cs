using System;

namespace ChatRoom_58A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            string str1 = Console.ReadLine().ToLower();
            int j = 0;
            string r = string.Empty;
            for (int i = 0; i < str1.Length; i++)
            {
                //check hello loop length
                if(j < 5)
                {  
                    if (str[j] == str1[i])
                    {  
                        j++;
                        r = r + str1[i];
                    }
                }               
            }
            if(r == str)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            

        }
    }
}

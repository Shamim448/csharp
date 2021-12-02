using System;

namespace String_Task_118A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string task = Console.ReadLine();
            task = task.ToLower();
            int lengths = task.Length;
            char[] characters = task.ToCharArray();
            

            for(int i = 0; i < lengths; i++)
            {
                char c = characters[i];
                switch(c)
                {
                    case 'a':
                    case 'o':
                    case 'y':
                    case 'i':
                    case 'e':
                    case 'u':
                        break;

                    default:
                    Console.Write("." + c);
                        break;
                }
                
            }


            
               
            

        }
    }
}
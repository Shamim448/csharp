using System;

namespace HQP_133A
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int count = 0;
           
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'H' || input[i] == 'Q' || input[i] == '9')
                {
                    count++;
                    
                }              
               
            }
            if (count > 0)
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

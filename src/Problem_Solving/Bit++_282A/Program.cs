using System;

namespace Bit___282A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 0;
            
            int numberOfStatement = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 0; i < numberOfStatement; i++)
            {
                string result = Console.ReadLine();
                if(result[0] == '-' || result[2] == '-')
                {
                    X -= 1;
                }
                else if(result[0] == '+' || result[2] == '+')
                {
                    X += 1;
                }
            }
            Console.WriteLine(X);
        }
    }
}

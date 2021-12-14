using System;

namespace HelpfulMath_339A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();


            string[] num = s.Split('+');
            Array.Sort(num);
            for (int i = 0; i < num.Length; i++)
            {

                if (i < num.Length - 1)
                {
                    Console.Write(num[i] + "+");
                }
            }
            
            Console.WriteLine(num[num.Length - 1]);
        }
    }
}

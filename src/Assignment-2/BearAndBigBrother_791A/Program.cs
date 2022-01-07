
using System;

namespace BearAndBigBrother_791A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            string input = Console.ReadLine();
            string[] weight =input.Split(" ");
            int Limak = int.Parse( weight[0]);
            int Bob = int.Parse(weight[1]);
            while (Limak <= Bob)
            {
                Limak = 3 * Limak;
                Bob = 2 * Bob;

                result++;
            }
            Console.WriteLine(result);
        }
    }
}

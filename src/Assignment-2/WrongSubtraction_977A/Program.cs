using System;

namespace WrongSubtraction_977A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] number = input.Split(" ");
            int num1 = int.Parse(number[0]);
            int num2 = int.Parse(number[1]);

            int  r, i;
            
            for (i = 1; i <= num2; i++)
            {
                r = num1 % 10;
                if (r == 0)
                {
                    num1 /= 10;
                }
                else
                    num1 -= 1;
            }
            Console.WriteLine(num1);



        }
    }
}

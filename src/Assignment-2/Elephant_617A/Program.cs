using System;

namespace Elephant_617A
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            int point = 0, step = 0, a = 0, b = 0, c = 0, d = 0;

            point = input / 5;

            step = input % 5;

            if (step % 4 == 0)

            {
                a = step / 4;
            }

            else if (step % 3 == 0)

            {
                b = step / 3;
            }

            else if (step % 2 == 0)

            {
                c = step / 2;
            }

            else if (step % 1 == 0)

            {
                d = step / 1;
            }

            Console.WriteLine(point + a + b + c + d);




        }
    }
}

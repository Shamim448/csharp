using System;

namespace IncrementDecerementOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Post Increment/Decrement operator
            Console.WriteLine("****Example of Post Increment****");
            int i = 3;
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(i);

           
            Console.WriteLine("****Example of Post Decrement****");
            int i2 = 3;
            Console.WriteLine(i2);
            Console.WriteLine(i2--);
            Console.WriteLine(i2);

            // Pre Increment/Decrement operator
            Console.WriteLine("****Example of Pre Increment****");
            int a = 3;
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a);


            Console.WriteLine("****Example of Pre Decrement****");
            int b = 3;
            Console.WriteLine(b);
            Console.WriteLine(--b);
            Console.WriteLine(b);
        }
    }
}

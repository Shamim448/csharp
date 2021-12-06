using System;

namespace Clasess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teachar teachar1 = new Teachar();
            Teachar teachar2 = new Teachar();
            //Over-write clasess default value
            teachar1.age = 20;
            teachar1.name = "Shamim";
            Console.WriteLine(teachar1.age);
            Console.WriteLine(teachar1.name);
            // Collect value from default
            Console.WriteLine(teachar2.age);
            Console.WriteLine(teachar2.name);

        }
    }
}

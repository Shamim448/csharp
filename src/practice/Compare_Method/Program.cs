using System;

namespace Compare_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "shamim";
            string text2 = "Shamim";
            Console.WriteLine(String.Compare(text1, text2));

            Console.WriteLine(text1.CompareTo(text2));
            Console.WriteLine(text2.CompareTo(text1));
        }
    }
}

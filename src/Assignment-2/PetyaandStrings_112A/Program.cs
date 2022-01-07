using System;

namespace PetyaandStrings_112A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String A = Console.ReadLine();
            String B = Console.ReadLine();
            A = A.ToLower();
            B = B.ToLower();
            int result = 0;
            result =string.Compare(A,B);
            Console.WriteLine(result);

        }
    }
}

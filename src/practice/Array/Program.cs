using System;

namespace Array // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration and initialazation
            double[] balance = new double[5];
            balance[0] = 101.22;
            //Initialization with declaratinon
            int[] numbers = { 1, 2};
            //Initialization with declaratinon size
            int[] marks = new int[5] { 99, 100, 20, 85, 45};
            //Initialization with declaratinon omit size
            string[] names = new string[] { "Shamim", "Saba", "Fatema"};

            //Accessing the array
            Console.WriteLine(balance[0]);

            //Accessing array using for loop
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Marke[{0}] = {1}", i, marks[i]);
            }
            //Accessing array using foreach loop
            foreach(string i in names)
            {
                int j = 0;
                Console.WriteLine("Name[{0}] = {1}", j, i);
                j++;
            }

        }
    }
}

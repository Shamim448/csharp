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
            //Copy array
            int[] scores = marks;


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

            //-----------------Two Dimentional Array----------------
            int[,] grid= new int[3,5]; //1st value row 2nd value column
            grid[0,0] = 4;             // row 3 column 5
            grid[0,1] = 8;
            grid[1,3] = 6;
            foreach(int i in grid)
            {
                Console.WriteLine(i);
            }
            //Assign value with declaretion
            int[,] a = new int[3, 2] { { 5, 7 }, { 8, 6 }, { 9, 17 } }; // 3 row  2 cloumn
            for(int i = 0; i < a.GetLength(0); i++) // loop for row 3
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("Value[{0},{1}] : {2}", i, j, a[i, j]);
                }
            }

        }
    }
}

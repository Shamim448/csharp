// See https://aka.ms/new-console-template for more information
Console.WriteLine("Example of bitwise complement operator");

uint t = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
Console.WriteLine(t); //decimal value of binary data
Console.WriteLine(Convert.ToString(t, toBase: 2)); //binary formated output

uint b = ~ t; //Complement Operator it replace "1 to 0"  and "0 to 1"
Console.WriteLine("0000_1111_0000_1111_0000_1111_0000_1100");
Console.WriteLine(Convert.ToString(b, toBase: 2));
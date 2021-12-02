// See https://aka.ms/new-console-template for more information
Console.WriteLine("Example of Logical Operator!");
uint a = 0b_1100_0011;
uint b = 0b_1001_0011;
uint c = a & b; // and operation 
uint d = a | b; //Or operation
uint e = a ^ b; //Xor Operation

//And operation Both bit 1 hole result 1
Console.WriteLine(Convert.ToString(c, toBase: 2));
//Or operation jkono akta bit 1 hole result 1
Console.WriteLine(Convert.ToString(d, toBase: 2));
//XOR operation Both bit same hole result 0
Console.WriteLine(Convert.ToString(e, toBase: 2));






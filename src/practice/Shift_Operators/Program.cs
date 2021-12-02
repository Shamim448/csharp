// See https://aka.ms/new-console-template for more information
Console.WriteLine("Example of shift operators");
uint m = 0b_1100_1001_0000_0000_0001_0001;
Console.WriteLine($"Before:{Convert.ToString(m, toBase: 2)}");

uint y = m >> 3;
uint x = m << 3;
Console.WriteLine($"After:{ Convert.ToString(y, toBase: 2)}"); 
Console.WriteLine($"After:{ Convert.ToString(x, toBase: 2)}");


uint a = 0b_1101;
uint b = a >> 2;
uint c = a << 2;
Console.WriteLine($"Before:{Convert.ToString(a, toBase: 2) }");
Console.WriteLine($"After:{ Convert.ToString(b, toBase: 2) }");
Console.WriteLine($"After:{ Convert.ToString(c, toBase: 2) }");


using static DelegatesExample.Delegates;
Calculate calculate = sum;
int sum (int x, int y)
{
    return x + y;
}

void Print(Calculate calculate)
{
    var result = calculate(4, 5);
    Console.WriteLine(result);
}
Print(calculate);

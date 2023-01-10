
using DelegatesExample;
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
string GenerateLink(int c_Id, string e_Id)
{
    return $"https://shamim.com/campaign/track?c={c_Id}&e={e_Id}";
}
EmailSender emailSender = new EmailSender();
emailSender.SendBulkEmail(23, new List<string>() { "shamim@gmail.com", "ami@tomi.com" }, GenerateLink);
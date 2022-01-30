
using Delegates;
using static Delegates.DelegatesExample;

Calculate calculate = sum;
int sum(int a, int b)
{
    return a + b;
}

void print(Calculate calculate)
{
    int result = calculate(4, 6);
    Console.WriteLine(result);
}
 
print(calculate);

//
string GenerateLink(int campaignId, string email)
{
    string primaryLink = $"https://sa-shamim.com/campaign/tract";
    if (campaignId > 0)
        primaryLink += "?Id={campaignId}";
    if(!string.IsNullOrWhiteSpace(email))
        primaryLink += "&email={email}";
    return primaryLink;

}
string GenerateLink2(int campaignId, string email)
{
    string primaryLink = $"https://sa-shamim.com/campaign/tract";
    if (campaignId > 0)
        primaryLink += "?Id={campaignId}";
    else
        primaryLink += "?Id=0";
    if (!string.IsNullOrWhiteSpace(email))
        primaryLink += "&email={email}";
    else
        primaryLink += "&email=''";
    return primaryLink;
   

}
EmailSender emailsender = new EmailSender();
emailsender.BlukEmailSender(3, new List<string>() { "avb@gmail.com, abc@yahoo.com" }, GenerateLink);

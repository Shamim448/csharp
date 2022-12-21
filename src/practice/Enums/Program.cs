// See https://aka.ms/new-console-template for more information

using Enums;

AccountStatus accStatus = getStatus();
if(accStatus == AccountStatus.Pending)
{
    Console.WriteLine("Your account is {0}", accStatus);
}
if(accStatus == AccountStatus.Active)
{
    Console.WriteLine("Your account is {0}", accStatus);
}
AccountStatus getStatus()
{
    return AccountStatus.Active;
}
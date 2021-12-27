// See https://aka.ms/new-console-template for more information

using Enums;

AccountStatus accountStatus = GetStatus();

    if(accountStatus == AccountStatus.pending)
{
    Console.WriteLine(accountStatus);
}
    if(accountStatus == AccountStatus.acctive)
{
    //enum associated with integer value which start 0
    Console.WriteLine(accountStatus +  " " + (int)accountStatus);
}
AccountStatus GetStatus()
{
    return AccountStatus.acctive;
}

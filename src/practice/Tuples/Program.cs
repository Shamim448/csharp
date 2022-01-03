﻿// See https://aka.ms/new-console-template for more information
using Tuples;
User user = null;
Membership membership = new Membership();

(AccountCreationStatus status, User user) results = membership.CreateUser("shamim", "ghjgj");
var result = membership.CreateUser("shamim", "ghjgj");

Console.WriteLine(result.status);
Console.WriteLine(result.user.Username);

(string, string) phoneinfo = membership.GetPhoneInfo("Mediatec Helloo g31", "128 Gb");
Console.WriteLine(phoneinfo.Item1);
Console.WriteLine(phoneinfo.Item2);




//Nullable type
string address = null;
//int x = null; //can't set null
int? y = null; //set null because it's nullable type
if (y.HasValue)
{
    Console.WriteLine(y.Value);
}


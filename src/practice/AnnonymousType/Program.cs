// See https://aka.ms/new-console-template for more information
using AnnonymousType;

Membership membership = new Membership();

dynamic results = membership.CreateUser("shamim", "ghjgj");
Console.WriteLine(results.status);
Console.WriteLine(results.user.Username);
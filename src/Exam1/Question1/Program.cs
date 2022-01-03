using Question1;
MembershipService membershipService = new MembershipService();
var result = membershipService.GetMembers(5);
Console.WriteLine(result);

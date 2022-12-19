// See https://aka.ms/new-console-template for more information
using InterfaceApp;

Transections t1 = new Transections();
Transections t2 = new Transections("001","19/12/2022", 4500.00);
Transections t3 = new Transections("012", "19/12/2022", 4783.62);

t1.showTransection();
t2.showTransection();
t3.showTransection();
Console.ReadLine();

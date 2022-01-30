
using Events;
Botton botton = new Botton();
botton.click += Printmessage;
botton.click += Printmessage1;
botton.Activate("Hello");
void Printmessage(string messa) { 
    Console.WriteLine(messa);
}
void Printmessage1(string messa)
{
    Console.WriteLine("Another message:"+messa);
}


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

EmailSender sender = new EmailSender();

sender.Send += SendMail;
sender.BulkEmailSender(new List<string>() { "abc@yahoo.com", "xyz@gmail.com" }, "Test Mail", "Hello World!");

void SendMail(object sender, string message)
{
    Console.WriteLine(message);
    Console.WriteLine(sender);
}

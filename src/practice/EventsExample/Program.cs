// See https://aka.ms/new-console-template for more information
using EventsExample;

Button button = new Button();
button.Click += PrintMessage;
button.Click += PrintMessage2;
button.Activete("Hello");
void PrintMessage(string message)
{
    Console.WriteLine(message);
}
void PrintMessage2(string message)
{
    Console.WriteLine("Another " + message);
}

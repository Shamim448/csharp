namespace Access_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 10;
            r.width = 15;
            r.Display();
            r.calculateArea()  // Not accessable because of private
            Console.ReadLine();
            
        }
    }
}
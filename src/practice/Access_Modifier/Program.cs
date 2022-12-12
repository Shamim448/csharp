namespace Access_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher Teachar = new Teacher();
            Teachar.age = 30;
            Teachar.name = "test";
            Teachar.generateId();

            Teacher teachar1 = new Teacher();
            teachar1.age = 29;
            teachar1.name = "saba";
            teachar1.generateId();
            Console.WriteLine( teachar1.Id );
            Console.WriteLine( Teachar.id );//id private
            
        }
    }
}
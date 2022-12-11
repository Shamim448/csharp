namespace Access_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher Teachar = new Teacher();
            Teachar.id = 1;
            Teachar.name = "test";

            Teacher teachar1 = new Teacher();
            teachar1.id = 2;
            teachar1.name = "saba";
        }
    }
}
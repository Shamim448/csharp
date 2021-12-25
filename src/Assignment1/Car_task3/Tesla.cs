

namespace Car_task3
{
    internal class Tesla : Car
    {
        public string BrandName;
        public Tesla(string name, string type, string color):base(type, color)
        {
            BrandName = name;
           
        }
       
    }
}

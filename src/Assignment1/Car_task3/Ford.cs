using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_task3
{
    internal class Ford : Car 
    {
        
            public string BrandName;
            public Ford(string name, string color, string type, int year) : base(type, color)
            {
                BrandName = name;
                Year = year;

            }
            public void GetCarModel(string firstname, string lastname)
            {
                Model = firstname +" " + lastname;
            }
        
    }
}

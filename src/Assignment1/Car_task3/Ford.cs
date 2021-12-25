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
            public Ford(string name,  string type, string color, int year) : base(type, color, year)
            {
                BrandName = name;
                
            }
            
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_task3
{
    public class ElectricCar : Car
    {
        //Overload 3
        public ElectricCar(string type, string model, string name) : base(model, name)
        {
            this.CarType = type;
        }
    }
}

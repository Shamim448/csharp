using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Car
    {
        public IEngine Engine { get; set; }
        public int Speed { get; set; }
        public Car(IEngine engine) {
            Engine= engine;
        }
        public void CarStart()
        {
            Engine.Start(); //Abstraction because Start methon run from IEngin interface
        }
        public void IncreaseSpeed(int speed)
        {
            Speed += speed;
        }

    }
}

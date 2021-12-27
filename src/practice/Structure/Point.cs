using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    internal struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Distance (Point anotherPoint)
        {
            return (anotherPoint.X - X ) + (anotherPoint.Y - Y);
        }

    }

    internal class Test
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Distance(Point anotherPoint)
        {
            return (anotherPoint.X - X) + (anotherPoint.Y - Y);
        }

    }
}

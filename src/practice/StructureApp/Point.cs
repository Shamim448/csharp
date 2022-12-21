using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureApp
{
    internal struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Distance( Point anotherpoints)
        {
            return (anotherpoints.X - X) + (anotherpoints.Y - Y);
        }
    }
}

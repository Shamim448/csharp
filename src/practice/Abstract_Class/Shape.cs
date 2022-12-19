using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public abstract class Shape
    {
        public double width { get; set; }
        public double length { get; set; }
        public abstract double area(); // only create signature
    }
}

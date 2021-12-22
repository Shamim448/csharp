using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double width, double height )
        {
            this.Base = width;
            this.Height = height;
        }
        public override double Area()
        {
            return 0.5 * Base * Height;
        }
        public override double Periameter()
        {
            return 0;
        }
    }
}

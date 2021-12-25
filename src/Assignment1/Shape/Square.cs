

namespace Shapes
{
    public class Square : Shape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            this.Side = side; 
        }
        public override double Area()
        {
            return Math.Pow(Side, 2);
        }
        public override double Periameter()
        {
            return Side * 4;
        }
    }
}


namespace Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle( double radius) 
        {
            this.Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double Periameter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}

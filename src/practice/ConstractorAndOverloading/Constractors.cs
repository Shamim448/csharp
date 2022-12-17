using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstractorAndOverloading
{
    internal class Line
    {
        public double length;

        public Line() {
            Console.WriteLine("Object is being created.");
        }
        public Line(double len) // Paramiterize constractor/ constractor overloding
        {
            length = len;
            Console.WriteLine("Length the Line from paramitarized constractor : {0}",length);
        }
        public Line(int len) //Constractor overloding
        {
            length = len;
            Console.WriteLine("Length the Line from overloading : {0}", length);
        }
        public void setLenght(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
    }
}

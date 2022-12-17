using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier
{
    public class Rectangle
    {
        public int length;
        public int width;
        private double calculateArea() { 
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length : {0}", length);
            Console.WriteLine("Width : {0}", width);
            Console.WriteLine("Area of Rectangle : {0}", calculateArea());
        }
    }
}

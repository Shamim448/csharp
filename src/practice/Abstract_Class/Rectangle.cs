using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Rectangle : Shape
    {
        
        public override double area()
        {
            return length * width;
        }
    }
}

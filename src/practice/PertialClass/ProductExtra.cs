using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PertialClass
{
    internal partial class Product
    {
        public string Description { get; set; } 
        public string ShortDescription(int length)
        {
            return Name + "(" + Description.Substring(0, length) + ")";
        }
    }
}

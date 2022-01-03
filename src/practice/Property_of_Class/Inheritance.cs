using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_of_Class
{
    internal class Inheritance:Overloading
    {
        public string Camera { get; set; }
        //method override 
        public void GetPhoneInfo(string processor, string ram)
        {
            Processor = processor;
            RAM = ram;
        }
    }
}

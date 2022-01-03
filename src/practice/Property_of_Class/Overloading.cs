using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_of_Class
{
    internal class Overloading
    {
        //Readonly permit set value only inside the constractor
        public readonly int Price;
        public readonly string Color;
        public Overloading()
        {
            Price = 20000;
        }
        //Constructor overloading
        public Overloading(int price, string color)
        {
            Price = price;
            Color = color;
        }

        public string BrandName{ get; set; }
        public string Model{ get; set; }
        public string Processor{ get; set; }
        public string RAM { get; set; }

        public void GetPhoneInfo(string processors)
        {
            //this.Processor = processors;
        }
        //overload
        public void GetPhoneInfo(string processor, string ram)
        {
            Processor = processor;
            RAM = ram;
        }
    }
}

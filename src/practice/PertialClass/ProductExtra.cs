using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PertialClass
{
    internal partial class Product
    {
       public string productCode { get; set; }
        public void productSummery()
        {
            Console.WriteLine("Product Code : {0} Product Name : {1} ", productCode, Name); //name come from partial class
        }
    }
}

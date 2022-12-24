using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    internal class Points <T>
    {
        public T X { get; set; }
        public T Y { get; set; }
    }
}

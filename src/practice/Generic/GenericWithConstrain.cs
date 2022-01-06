using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class GenericWithConstrain<T, V>where T : class, new()
        where V : struct
    {
        public T Name { get; set; }
        public V Value { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class GenericPoint<T> where T : struct
    {
        public T X { get; set; }
        public T Y { get; set; }

        public GenericPoint<T> sum(T x, T y)
        {
            var newItem = new GenericPoint<T>();
            //newItem.X += x;
            newItem.X = x;
            newItem.Y = y;
            return newItem;
        }
    }
    
}
 
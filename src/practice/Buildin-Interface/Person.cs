using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildin_Interface
{
    public class Person:ICloneable
    {
        public string Name { get; set; }

        public object Clone()
        {
            return new Person() { Name = Name };s
        }
    }
}

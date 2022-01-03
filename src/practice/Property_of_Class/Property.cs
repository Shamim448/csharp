using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_of_Class
{
    internal class Property
    {
        public string? Name;
        public string name
        {
            get => Name;
            set
            {
                if (value.StartsWith('S'))
                {
                    Name = value;
                }
            }
        }
    }
}

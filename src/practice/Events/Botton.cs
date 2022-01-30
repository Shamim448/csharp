using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Botton
    {
        public delegate void Onclick(string message);
        public event Onclick click;

        public void Activate(string message)
        {
            click.Invoke("Shamim");
        }
    }
}

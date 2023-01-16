using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class Button
    {
        public delegate void ClickEvent(string text);
        public event ClickEvent Click;

       public void Activete(string message)
        {
            if(! string.IsNullOrWhiteSpace(message))
            {
                 Click.Invoke(message);
            }
            else
            {
                 Click.Invoke(string.Empty);
            }
        }
    }
}

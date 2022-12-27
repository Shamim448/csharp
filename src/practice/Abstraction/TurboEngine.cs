using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class TurboEngine : IEngine
    {
        public String Status { get; set; }
        public void Start()
        {
            Status = "Engine Started";
            //something write here
            Console.WriteLine(Status);
        }
    }
}

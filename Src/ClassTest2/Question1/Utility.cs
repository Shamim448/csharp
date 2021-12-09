using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Utility
    {
        public static string Reverse(string str)
        {
            string revStr = string.Empty;
            
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr += str[i];
            }
            return revStr;
            
        }
    }
}

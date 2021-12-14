using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    internal class sortString
    {
         internal static string SortString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Sort(chars);
            return new string (chars);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class Palindrome
    {
        public string text;
        public  bool IsPalindrome(string str)
        {
            int low = 0;
            int high = str.Length-1;

            while (low < high)
            {
                // if mismatch happens
                if (str[low] != str[high])
                    return false;

                low++;
                high--;
            }

            return true;




        }
    }
}

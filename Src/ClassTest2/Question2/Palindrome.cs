using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class Palindrome
    {
       
        public  bool IsPalindrome(string str)
        {
            string text = str.ToLower();
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;




        }
    }
}

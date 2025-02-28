using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DSA_Solutions
{
    public static class PalindromeCheck
    {
        public static bool IsPalindrome(string str)
        {
            string reversed = ReverseString.Reverse(str);
            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
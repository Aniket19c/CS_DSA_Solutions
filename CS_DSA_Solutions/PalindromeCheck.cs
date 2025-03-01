using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DSA_Solutions
{
    public static class PalindromeCheck
    {
        public static bool IsPalindrome(string s)
        {
            string k = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                k += s[i];
            }
            return s.Equals(k);
        }
    }
}
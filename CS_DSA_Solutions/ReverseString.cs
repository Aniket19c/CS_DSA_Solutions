using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DSA_Solutions
{
    public static class ReverseString
    {
        public static string Reverse(string str)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
                reversed.Append(str[i]);
            return reversed.ToString();
        }
    }
}
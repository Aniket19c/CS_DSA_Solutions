using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DSA_Solutions
{
    public static class AnagramCheck
    {
        public static bool AreAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            return str1.OrderBy(c => c).SequenceEqual(str2.OrderBy(c => c));
        }
    }
}

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

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int i = 0; i < str1.Length; i++)
            {
               
                if (charCount.ContainsKey(str1[i]))
                    charCount[str1[i]]++;
                else
                    charCount[str1[i]] = 1;

                if (charCount.ContainsKey(str2[i]))
                    charCount[str2[i]]--;
                else
                    charCount[str2[i]] = -1;
            }

         
            foreach (var count in charCount.Values)
            {
                if (count != 0)
                    return false;
            }

            return true;
        }
    }
}

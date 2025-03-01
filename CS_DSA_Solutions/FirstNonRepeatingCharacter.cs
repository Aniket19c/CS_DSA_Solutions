using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DSA_Solutions
{
    public static class FirstNonRepeatingCharacter
    {
        public static char? FindFirstNonRepeatingChar(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

         
            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            foreach (char c in str)
            {
                if (charCount[c] == 1)
                    return c;
            }

            return null; 
        }
    }
}

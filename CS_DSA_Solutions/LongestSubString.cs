using System;
using System.Collections.Generic;

namespace CS_DSA_Solutions
{
    public static class LongestSubString
    {
        public static int MaxLength(string s)
        {
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            int maxLength = 0, left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                if (charIndexMap.ContainsKey(s[right]) && charIndexMap[s[right]] >= left)
                {
                    left = charIndexMap[s[right]] + 1;
                }

                charIndexMap[s[right]] = right;
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}

using System;

namespace CS_DSA_Solutions
{
    public static class StringRotation
    {
        public static bool IsRotation(string str1, string str2)
        {
            if (str1.Length != str2.Length || str1.Length == 0)
                return false;

            string concatenated = str1 + str1;
            return concatenated.Contains(str2);
        }
    }
}
using System;

public class StringCompression
{
    public static string ToCompress(string s)
    {
        string sol = "";
        for (int i = 0; i < s.Length; i++)
        {
            int count = 1;
            while (i < s.Length - 1 && s[i] == s[i + 1])
            {
                count++;
                i++;
            }
            sol += s[i];
            if (count > 1)
            {
                sol += count.ToString();
            }
        }
        return sol;
    }

    
}

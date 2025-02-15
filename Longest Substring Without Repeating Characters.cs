using System;

public class LongestSubstringProgram
{
    public static int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;
        int start = 0;
        var charIndexMap = new Dictionary<char, int>();

        for (int end = 0; end < s.Length; end++)
        {
            char currentChar = s[end];

            if (charIndexMap.ContainsKey(currentChar) && charIndexMap[currentChar] >= start)
            {
                start = charIndexMap[currentChar] + 1;
            }

            charIndexMap[currentChar] = end;

            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }

    public static void Main()
    {
        string input = "abcabcbb";
        int result = LengthOfLongestSubstring(input);
        Console.WriteLine(result);
    }
}

using System.Collections;

namespace LeetCode.Learning.Sliding_Window;

public class LongestSubstringLengthWithKDistinctCharacters_Solution
{
    public static void Run()
    {
        Console.WriteLine(LongestSubstringLengthWithKDistinctCharacters("AAAHHIBC", 4));
    }

    public static int LongestSubstringLengthWithKDistinctCharacters(string s, int k)
    {
        Dictionary<char, int> dict = new();

        string result = "";
        int start = 0;

        foreach (char c in s)
        {
            result += c;

            if (dict.ContainsKey(c))
            {
                dict[c] += 1;
            }
            else
            {
                dict[c] = 1;
            }

            while(dict.Keys.Count > k)
            {
                char rc = result[start];

                result = result.Remove(start, 1);
                dict[rc] -= 1;

                if (dict[rc] == 0)
                {
                    dict.Remove(rc);
                }
            }
        }
        
        return result.Length;
    }
}

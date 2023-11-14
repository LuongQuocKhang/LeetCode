using System.Diagnostics;

namespace LeetCode.Solution.Medium;

public class LongestSubstringWithoutRepeatingCharacters_Solution
{
    /***
     * Start Time: 12/11/2023 2:57 PM
     * End Time:12/11/2023 3:20 PM
     * Result: 
     * Runtime: Beats 5.04% of users with C# ( 249ms )
     * Memory: Beats 5.68% of users with C# ( 124.16MB )
     * Need to search more effecient solution
     */

    public static void Run()
    {
        Stopwatch sw = Stopwatch.StartNew();

        Console.WriteLine(LengthOfLongestSubstring("  "));

        sw.Stop();

        Console.WriteLine("LengthOfLongestSubstring: " + sw.ElapsedMilliseconds);

        sw.Restart();
        Console.WriteLine(LengthOfLongestSubstring_sw("  "));
        sw.Stop();

        Console.WriteLine("LengthOfLongestSubstring_sw:" + sw.ElapsedMilliseconds);
    }

    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 1) return 1;

        List<string> results = new List<string>();

        string result = "";

        for (int i = 0; i < s.Length - 1; i++)
        {
            string c = s[i].ToString();

            result += c;

            for (int j = i + 1; j < s.Length; j++)
            {
                if (result.Contains(s[j].ToString()))
                {
                    break;
                }
                if (c == s[j].ToString())
                {
                    break;
                }

                result += s[j];
            }

            results.Add(result);
            result = string.Empty;
        }
        return results.Any() ? results.Select(x => x.Length).Max() : 0;
    }

    public static int LengthOfLongestSubstring_sw(string s)
    {
        int start = 0, end = 0;

        string result = "";
        // | |
        // abcsdda


        return 0;
    }
}

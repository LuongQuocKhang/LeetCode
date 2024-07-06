using System.Text.RegularExpressions;

namespace LeetCode.String.Easy;

public class RomanToInteger
{
    /***
   * Tag: Easy
   * Name: 13. Roman to Integer
   * Start Time: 06/07/2024 15:30 PM
   * End Time: 06/07/2024 15:32 PM
   * Result: 
       * Runtime: solution 1: Beats 94.35% of users with C# ( 43ms )
       * Memory:  solution 1: Beats 9.58% of users with C# ( 51.76MB )
   ***/

    public static void Run()
    {
        // 1000 + 100 + 1000 + 10 + 100 + 4
        Console.WriteLine(RomanToInt("MCMXCIV"));
    }

    public static int RomanToInt(string s)
    {
        Dictionary<char, int> map = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        Dictionary<string, int> exception = new Dictionary<string, int>()
        {
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40 },
            { "XC", 90 },
            { "CD", 400 },
            { "CM", 900 },
        };

        char previous = default;

        int total = 0;

        foreach (char c in s)
        {
            if ((previous == 'I' && (c == 'V' || c == 'X'))
                || previous == 'X' && (c == 'L' || c == 'C')
                || previous == 'C' && (c == 'D' || c == 'M'))
            {
                total -= map[previous];

                total += exception[new string([previous, c])];
            }
            else
            {
                total += map[c];
            }

            previous = c;
        }

        return total;


        //// count IX, IV

        //int IXCount = Regex.Matches(s, "IX").Count;
        //int IVCount = Regex.Matches(s, "IV").Count;

        //int XLCount = Regex.Matches(s, "XL").Count;
        //int XCCount = Regex.Matches(s, "XC").Count;

        //int CDCount = Regex.Matches(s, "CD").Count;
        //int CMCount = Regex.Matches(s, "CM").Count;

        //s = s
        //    .Replace("IX", string.Empty)
        //    .Replace("IV", string.Empty)
        //    .Replace("IX", string.Empty)
        //    .Replace("CD", string.Empty)
        //    .Replace("CM", string.Empty)
        //    .Replace("XL", string.Empty)
        //    .Replace("XC", string.Empty);

        //return IXCount * 9 
        //    + IVCount * 4 
        //    + XLCount *  40
        //    + XCCount *  90
        //    + CDCount * 400
        //    + CMCount * 900
        //    + s.Sum(x => Convert(x));
    }

    private static int Convert(char c)
    {
        return c switch
        {
            'I' => 1,
            'X' => 10,
            'V' => 5,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };
    }
}

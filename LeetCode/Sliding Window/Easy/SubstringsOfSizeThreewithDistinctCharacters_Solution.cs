namespace LeetCode.Sliding_Window.Easy;


public static class SubstringsOfSizeThreewithDistinctCharacters_Solution
{
    /***
    * Start Time: 14/11/2023 2:47 PM
    * End Time: 14/11/2023 3:33 PM
    * Result: 
    * Runtime: solution 1: Beats 75.24% of users with C# ( 42 ms )
    * Memory:  solution 1: Beats 14.49% of users with C# ( 39.28MB )
    */

    public static void Run()
    {
        string s = "aababcabc";
        Console.WriteLine(CountGoodSubstrings(s));
    }

    public static int CountGoodSubstrings(string s)
    {
        int count = 0;

        for (int start = 0; start < s.Length - 2; start++)
        {
            if (s[start] != s[start + 1]
                && s[start + 1] != s[start + 2]
                && s[start] != s[start + 2])
            {
                count++;
            }
        }

        return count;
    }
}

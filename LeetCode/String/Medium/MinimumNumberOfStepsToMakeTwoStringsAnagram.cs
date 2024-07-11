namespace LeetCode.String.Medium;

public class MinimumNumberOfStepsToMakeTwoStringsAnagram
{
    /***
    * Tag: Medium
    * Name: 1347. Minimum Number of Steps to Make Two Strings Anagram
    * Start Time: 11/07/2024 11:31 AM
    * End Time: 11/07/2024 11:35 AM
    * Result: 
        * Runtime: solution 1: Beats 27.22% of users with C# ( 97ms )
        * Memory:  solution 1: Beats 84.81% of users with C# ( 53.14MB )
    ***/

    public static void Run()
    {
        string s = "anagram", t = "mangaar";

       System.Console.WriteLine(MinSteps(s, t));
    }

    public static int MinSteps(string s, string t) 
    {
        Dictionary<char, int> map  = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if(map.ContainsKey(c)) {
                map[c]++;
            }
            else {
                map[c] = 1;
            }
        }
        int steps = 0;

        foreach (char c in t)
        {
            if(map.ContainsKey(c)) {
                int minus = map[c] - 1;
                if(minus < 0)
                {
                    steps++;
                }
                else {
                    map[c] = minus;
                }
            }
            else {
                steps++;
            }
        }
        return steps;
    }

}
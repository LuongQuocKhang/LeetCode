namespace LeetCode.String.Easy;

public class PermutationDifferenceBetweenTwoStrings
{
    /***
   * Tag: Easy
   * Name: 2582. Pass the Pillow
   * Start Time: 06/07/2024 14:14 AM
   * End Time: 06/07/2024 14:16 PM
   * Result: 
      * Runtime: solution 1: Beats 95.65% of users with C# ( 12ms )
      * Memory:  solution 1: Beats 56.52% of users with C# ( 26.83MB )
  ***/
    public static void Run()
    {
        Console.WriteLine(FindPermutationDifference("abcde", "edbac"));
    }

    public static int FindPermutationDifference(string s, string t)
    {
        int total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int index = t.IndexOf(s[i]);

            total += Math.Abs(index - i);
        }

        return total;
    }
}

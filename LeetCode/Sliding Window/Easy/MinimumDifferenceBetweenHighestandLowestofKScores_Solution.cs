namespace LeetCode.Sliding_Window.Easy;

internal class MinimumDifferenceBetweenHighestandLowestofKScores_Solution
{
    /***
   * Start Time: 24/02/2024 5:10 PM
   * End Time: 24/02/2024 4:53 PM
   * Result: 
   * Runtime: solution 1: Beats 60.61% of users with C# ( 101ms )
   * Memory:  solution 1: Beats 19.70% of users with C# ( 46.38MB )
   */

    public static void Run()
    {
        int[] nums = { 9, 4, 1, 7 };
        int k = 1;

        Console.WriteLine(MinimumDifference(nums, k));
    }

    public static int MinimumDifference(int[] nums, int k)
    {
        if (nums.Length == 0) return 0;

        return 0;
    }
}

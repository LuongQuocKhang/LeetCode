namespace LeetCode.Sliding_Window.Easy;

public class FindMaxAverage_Solution
{
    /***
    * Start Time: 14/11/2023 3:33 PM
    * End Time: 14/11/2023 3:43 PM
    * Result: 
    * Runtime: solution 1: Beats 97.95% of users with C# (237ms)
    * Memory:  solution 1: Beats 54.79% of users with C# (59.89MB)
    */

    public static void Run()
    {
        int[] nums = { 1, 12, -5, -6, 50, 3 };
        int k = 4;

        Console.WriteLine(FindMaxAverage(nums, k));
    }

    public static double FindMaxAverage(int[] nums, int k)
    {
        double max = double.MinValue,
            average = 0;

        for (int end = 0; end < nums.Length; end++)
        {
            average += ((double)nums[end] / (double)k);

            if (end >= k - 1)
            {
                max = Math.Max(max, average);
                average -= ((double)nums[end - k + 1] / (double)k);
            }
        }

        return max;
    }
}

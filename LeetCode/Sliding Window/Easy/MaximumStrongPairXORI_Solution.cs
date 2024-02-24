namespace LeetCode.Sliding_Window.Easy;

public class MaximumStrongPairXORI_Solution
{
    /***
    * Start Time: 11/2/2024 11:56 AM
    * End Time: 11/2/2024 12:13 PM
    * Result: 
    * Runtime: solution 1: Beats 92.65% of users with C# ( 67ms )
    * Memory:  solution 1: Beats 64.71% of users with C# ( 42.82MB )
    */

    public static void Run()
    {
        int[] nums = { 1, 2, 3, 4, 5 };

        Console.WriteLine(MaximumStrongPairXor(nums));
    }

    public static int MaximumStrongPairXor(int[] nums)
    {
        int max = int.MinValue;

        for (int x = 0; x < nums.Length; x++)
        {
            for (int y = x; y < nums.Length; y++)
            {
                if ((Math.Abs(nums[x] - nums[y]) <= Math.Min(nums[x], nums[y])) && max < (nums[x] ^ nums[y]))
                {
                    max = nums[x] ^ nums[y];
                }
            }
            
        }

        return max;
    }
}

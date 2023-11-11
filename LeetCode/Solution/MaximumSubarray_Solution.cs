namespace LeetCode.Solution;

public class MaximumSubarray_Solution : ISolution
{
    public void Run()
    {
        int[] nums = { 5528, -444, -2520, 8588, 5526, -4508, 3202, 1735, 8208 };

        Console.WriteLine(MaxSubArray(nums));
    }

    private static int MaxSubArray(int[] nums)
    {
        int max = int.MinValue;
        int current_sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            current_sum += nums[i];

            if (current_sum > max)
            {
                max = current_sum;
            }

            if (current_sum < 0)
            {
                current_sum = 0;
            }
        }

        return max;
    }
}

namespace LeetCode.Learning.Sliding_Window.Easy;

public class SmallestSubArray_Solution
{
    public static void Run()
    {
        int[] nums = { 4, 2, 2, 7, 8, 1, 2, 8, 10 };
        int target = 8;
        Console.WriteLine(SmallestSubArray(nums, target));
    }

    public static int SmallestSubArray(int[] nums, int target)
    {
        int minWindowSize = int.MaxValue;
        int start = 0;
        int currentWindowSum = 0;

        for (int end = 0; end < nums.Length; end++)
        {
            currentWindowSum += nums[end];

            while(currentWindowSum >= target)
            {
                minWindowSize = Math.Min(minWindowSize, end - start + 1);
                currentWindowSum -= nums[start];
                start++;
            }
        }

        return minWindowSize;
    }
}

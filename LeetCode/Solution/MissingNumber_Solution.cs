namespace LeetCode.Solution;

public class MissingNumber_Solution
{
    public static void Run()
    {
        int[] nums = { 3, 0, 1 };

        Console.WriteLine(MissingNumber(nums));
    }

    private static int MissingNumber(int[] nums)
    {
        int length = nums.Length;

        int missingNumbers = 0;

        Array.Sort(nums);

        int max = nums[nums.Length - 1];

        for (int i = 0; i < max; i++)
        {
            if (Array.IndexOf(nums, i) < 0)
            {
                missingNumbers = i;
            }
        }
        if (Array.IndexOf(nums, length) < 0 && length > max)
        {
            missingNumbers = length;
        }
        return missingNumbers;
    }
}

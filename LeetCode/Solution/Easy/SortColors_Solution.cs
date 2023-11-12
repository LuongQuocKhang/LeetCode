namespace LeetCode.Solution.Easy;

public class SortColors_Solution
{
    public static void Run()
    {
        int[] nums = { 2, 0, 2, 1, 1, 0 };
        SortColors(nums);
    }

    public static void SortColors(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < nums[i])
                {
                    int num1 = nums[i];
                    int num2 = nums[j];

                    nums[i] = num2;
                    nums[j] = num1;
                }
            }
        }
    }
}

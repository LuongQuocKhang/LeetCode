namespace LeetCode.Arrays.Easy;

public static class BuildArrayfromPermutation
{
    public static void Run()
    {
        int[] nums = [0,2,1,5,3,4];

        int[] ans = BuildArray(nums);

        foreach (int i in ans)
        {
            Console.WriteLine(i);
        }
    }

    private static int[] BuildArray(int[] nums)
    {
       return nums.Select(x => nums[x]).ToArray();
    }
}

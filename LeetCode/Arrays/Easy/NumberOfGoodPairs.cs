namespace LeetCode.Arrays.Easy;

public static class NumberOfGoodPairs
{
    /***
        * Name: 1512. Number of Good Pairs
        * Start Time: 01/07/2023 10:05 AM
        * End Time: 01/07/2023 10:15 AM
        * Result: 
            * Runtime: solution 1: Beats 54.30% of users with C# ( 170ms )
            * Memory:  solution 1: Beats 14.49% of users with C# ( 61.41MB )
    ***/

    public static void Run()
    {
        int[] nums = [1, 2, 3, 1, 1, 3];

        int result = NumIdenticalPairs(nums);

        Console.WriteLine(result);
    }
    public static int NumIdenticalPairs(int[] nums)
    {
        int result = 0;
        // O(n^2) - n * ( n - 1 )
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[j] == nums[i])
                {
                    result++;
                }
            }
        }

        return result;
    }
}

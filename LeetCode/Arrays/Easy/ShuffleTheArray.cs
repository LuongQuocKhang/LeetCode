namespace LeetCode.Arrays.Easy;

public static class ShuffleTheArray
{
    /***
       * Name: 1470. Shuffle the Array
       * Start Time: 01/07/2023 10:15 AM
       * End Time: 01/07/2023 10:29 AM
       * Result: 
           * Runtime: solution 1: Beats 57.73% of users with C# ( 113ms )
           * Memory:  solution 1: Beats 28.04% of users with C# ( 48.58MB )
   ***/
    public static void Run()
    {
        int[] nums = [1, 2, 3, 4, 4, 3, 2, 1];
        int n = 4;

        foreach (var item in nums)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        int[] result = Shuffle(nums, n);

        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
    }

    public static int[] Shuffle(int[] nums, int n)
    {
        int length = nums.Length;
        int[] leftNums = nums.Take(n).ToArray();
        int[] rightNums = nums.Skip(n).Take(n).ToArray();

        List<int> result = new List<int>();

        for (int i = 0; i < n; i++)
        {
            result.Add(leftNums[i]);
            result.Add(rightNums[i]);
        }

        return result.ToArray();
    }
}

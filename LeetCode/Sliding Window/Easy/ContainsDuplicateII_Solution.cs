using System;

namespace LeetCode.Sliding_Window.Easy;

public class ContainsDuplicateII_Solution
{
    /***
    * Start Time: 14/11/2023 2:47 PM
    * End Time: 14/11/2023 3:33 PM
    * Result: 
    * Runtime: solution 1: Beats 93.61% of users with C# ( 170ms )
    * Memory:  solution 1: Beats 14.49% of users with C# ( 61.41MB )
    */

    public static void Run()
    {
        int[] nums = { 4, 1, 2, 3, 1, 5 };
        int k = 3;

        Console.WriteLine(ContainsNearbyDuplicate(nums, k));
    }

    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> map = new();

        for (int end = 0; end < nums.Length; end++)
        {
            if (map.ContainsKey(nums[end]))
            {
                int index = map[nums[end]];

                if (Math.Abs(index - end) <= k)
                {
                    return true;
                }
                else
                {
                    map[nums[end]] = end;
                }
            }
            else
            {
                map.Add(nums[end], end);
            }
        }

        return false;
    }
}

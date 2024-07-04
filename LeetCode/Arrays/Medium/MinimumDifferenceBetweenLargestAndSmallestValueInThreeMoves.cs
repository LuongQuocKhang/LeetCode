using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays.Medium;

public static class MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves
{
    /***
    * Tag: Medium
    * Name: 1828. Queries on Number of Points Inside a Circle
    * Start Time: 03/07/2024 16:30 PM
    * End Time: 02/07/2024 10:30 AM
    * Result: 
        * Runtime: solution 1: Beats 81.82% of users with C# ( 203ms )
        * Memory:  solution 1: Beats 81.82% of users with C# ( 57.53MB )
    ***/

    public static void Run()
    {
        Console.WriteLine(MinDifference([6, 6, 0, 1, 1, 4, 6]));
    }

    public static int MinDifference(int[] nums)
    {
        if (nums.Length <= 4)
        {
            return 0;
        }

        Array.Sort(nums);

        // 0 1 1 4 6 6 6
        // only change 3 value => i < 4

        int result = int.MaxValue;
        int n = nums.Length;

        for (int i = 0; i < 4; i++)
        {
            // last 3 largest number change to 0 (smallest) => compare the largest number 4 and 3 ... 
            result = Math.Min(result, nums[n - 4 + i] - nums[i]);
        }

        return result;
    }
}

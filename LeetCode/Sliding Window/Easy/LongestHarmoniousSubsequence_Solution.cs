namespace LeetCode.Sliding_Window.Easy;

public class LongestHarmoniousSubsequence_Solution
{
    /***
       * Start Time: 24/02/2024 2:51 PM
       * End Time: 24/02/2024 3:16 PM
       * Result: 
       * Runtime: solution 1: 162ms Beats 65.22% of users with C#
       * Memory:  solution 1: 56.55MB Beats 27.54% of users with C#
   */

    public static void Run()
    {
        int[] nums = { 1, 3, 2, 2, 5, 2, 3, 7 };

        //foreach (int i in nums)
        //{
        //    Console.Write(i + " ");
        //}

        Console.WriteLine(FindLHS(nums));
    }

    public static int FindLHS(int[] nums)
    {
        Dictionary<int, int> maps = new Dictionary<int, int>();

        foreach (int item in nums)
        {
            if (maps.ContainsKey(item))
            {
                maps[item]++;
            }
            else
            {
                maps[item] = 1;
            }
        }

        int numOfKeys = maps.Keys.Count;

        int max = 0;

        // 0 3 1 2 -3
        // 5 9 4 6 2
        
        var arrayOfAllKeys = maps.Keys.ToArray();

        Array.Sort(arrayOfAllKeys);

        for (int i = 0; i < numOfKeys; i++)
        {
            if (i + 1 >= numOfKeys) continue;

            if (!maps.ContainsKey(arrayOfAllKeys[i + 1])) continue;

            if (Math.Abs(arrayOfAllKeys[i + 1] - arrayOfAllKeys[i]) != 1) continue;

            int maxLength = maps[arrayOfAllKeys[i]] + maps[arrayOfAllKeys[i + 1]];

            max = maxLength > max ? maxLength : max;
        }

        return max;
    }
}

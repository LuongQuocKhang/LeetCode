namespace LeetCode.Arrays.Medium;

public static class ConvertAnArrayIntoA2DArrayWithConditions
{
    /***
     * Tag: Medium
     * Name: 2610. Convert an Array Into a 2D Array With Conditions
     * Start Time: 01/07/2024 15:30 AM
     * End Time: 01/07/2024 15:45 AM
     * Result: 
        * Runtime: solution 1: Beats 13.58% of users with C# ( 1250ms )
        * Memory:  solution 1: Beats 5.56% of users with C# ( 52.47MB )
    ***/

    public static void Run()
    {
        int[] nums = [1, 3, 4, 1, 2, 3, 1];

        IList<IList<int>> result = FindMatrix(nums);
    }

    public static IList<IList<int>> FindMatrix(int[] nums)
    {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>()
        {
            [0] = new List<int>()
        };

        IList<IList<int>> result = new List<IList<int>>();

        int count = 0;
        // O(n * m)
        for (int i = 0; i < nums.Length; i++)
        {
            bool hasValue = false;

            foreach (int key in dict.Keys)
            {
                if (!dict[key].Any(x => x == nums[i]))
                {
                    hasValue = true;
                    dict[key].Add(nums[i]);
                    break;
                }
            }

            if (!hasValue)
            {
                count++;
                dict[count] = new List<int>()
                    {
                        nums[i]
                    };
            }
        }
        // O(m)
        foreach (List<int> value in dict.Values)
        {
            result.Add(value);
        }
        // => O(m * m)
        return result;
    }
}
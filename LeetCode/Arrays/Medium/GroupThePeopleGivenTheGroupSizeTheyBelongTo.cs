using System.Collections.Generic;

namespace LeetCode.Arrays.Medium;

public class GroupThePeopleGivenTheGroupSizeTheyBelongTo
{
    /***
     * Tag: Medium
     * Name: 1282. Group the People Given the Group Size They Belong To
     * Start Time: 01/07/2024 14:57 PM
     * End Time: 01/07/2024 15:13 AM
     * Result: 
        * Runtime: solution 1: Beats 71.93% of users with C# ( 115ms )
        * Memory:  solution 1: Beats 82.46% of users with C# ( 50.45MB )
    ***/


    public static void Run()
    {
        int[] groupSizes = [2, 1, 3, 3, 3, 2];

        IList<IList<int>> result = GroupThePeople(groupSizes);

    }

    public static IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < groupSizes.Length; i++)
        {
            if (!dict.ContainsKey(groupSizes[i]))
            {
                dict[groupSizes[i]] = new List<int>()
                {
                    i
                };
            }
            else
            {
                if (dict[groupSizes[i]].Count >= groupSizes[i])
                {
                    result.Add(dict[groupSizes[i]]);
                    dict[groupSizes[i]] = new List<int>();
                }
                dict[groupSizes[i]].Add(i);
            }
        }

        foreach (int i in dict.Keys)
        {
            result.Add(dict[i]);
        }

        return result;
    }
}

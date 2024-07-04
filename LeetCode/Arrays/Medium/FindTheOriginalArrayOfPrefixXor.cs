using System;

namespace LeetCode.Arrays.Medium;

public static class FindTheOriginalArrayOfPrefixXor
{
    /***
    * Tag: Medium
    * Name: 2433. Find The Original Array of Prefix Xor
    * Start Time: 01/07/2024 11:30 AM
    * End Time: 01/07/2024 11:51 AM
    * Result: 
        * Runtime: solution 1: Beats 74.42% of users with C# ( 305ms )
        * Memory:  solution 1: Beats 5.81% of users with C# ( 87.70MB )
    ***/
    public static void Run()
    {
        int[] pref = [5, 2, 0, 3, 1];
        int[] result = FindArray(pref);

        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
    }

    public static int[] FindArray(int[] pref)
    {
        List<int> list = new List<int>()
        {
            pref[0]
        };

        for (int i = 1; i < pref.Length; i++)
        {
            list.Add(pref[i - 1] ^ pref[i]);
        }
        return list.ToArray();
    }

    private static int FindX(int num, int lastXor)
    {
        // a ^ x = b => x = a ^ b
        // 5 ^ x = 2
        // => x = 5 ( lastXor ) ^ 2
        return lastXor ^ num;
    }
}

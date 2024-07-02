using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays.Easy;

public static class ThreeConsecutiveOdds
{
    /***
    * Tag: Easy
    * Name: 1550. Three Consecutive Odds
    * Start Time: 01/07/2023 11:30 AM
    * End Time: 01/07/2023 11:51 AM
    * Result: 
        * Runtime: solution 1: Beats 92.86% of users with C# ( 63ms )
        * Memory:  solution 1: Beats 60.71% of users with C# ( 42.87MB )
    ***/
    public static void Run()
    {
        Console.WriteLine(ThreeConsecutiveOddsSolution([102, 780, 919, 897, 901]));
    }

    public static bool ThreeConsecutiveOddsSolution(int[] arr)
    {
        if(arr.Length == 3)
        {
            if (arr[0] == 1
                && arr[1] == 1
                && arr[2] == 1) return true;

            if (arr[0] % 2 != 0
                && arr[1] % 2 != 0
                && arr[2] % 2 != 0)
                return true;
        }

        for (int i = 0; i <= arr.Length - 3; i++)
        {
            if (arr[i] % 2 != 0
                && arr[i + 1] % 2 != 0
                && arr[i + 2] % 2 != 0)
            {
                return true;
            }
        }
        return false;
    }
}

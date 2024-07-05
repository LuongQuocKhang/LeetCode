using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays.Medium;

public class MinimumAmountOfTimeToCollectGarbage
{
    /***
     * Tag: Medium
     * Name: 2181. Merge Nodes in Between Zeros
     * Start Time: 04/07/2024 18:00 AM
     * End Time: 04/07/2024 18:15 PM
     * Result: 
        * Runtime: solution 1: Beats 8.00% of users with C# ( 438ms )
        * Memory:  solution 1: Beats 8.00% of users with C# ( 107.6MB )
    ***/

    public static void Run()
    {
        // 0 2 3
        string[] garbage = ["G", "P", "GP", "GG"];
        int[] travel = [2, 4, 3];
        Console.WriteLine(GarbageCollection(garbage, travel));
    }

    public static int GarbageCollection(string[] garbage, int[] travel)
    {
        int timeMetal = CalculateTime(garbage, travel, 'M'), 
            timePapper = CalculateTime(garbage, travel, 'P'), 
            timeGlass = CalculateTime(garbage, travel, 'G');

        return timeMetal + timePapper + timeGlass;
    }

    private static int CalculateTime(string[] garbage, int[] travel, char garbageType)
    {
        int time = 0;

        int length = garbage.Length;

        int[] houses = garbage.Select((value, index) =>
        {
            if (value.Contains(garbageType))
                return index;
            return -1;
        }).ToArray();

        if (houses.All(x => x == -1)) return 0;

        houses = houses.Where(x => x != -1).ToArray();

        int totalCollectTime = garbage.Select((value, index) =>
        {
            if (value.Contains(garbageType))
                return value.Count(x => x == garbageType);
            return 0;
        }).Sum();

        time += totalCollectTime;

        int max = houses.Max();

        for (int i = 0; i < max; i++)
        {
            time += travel[i];
        }

        return time;
    }
}

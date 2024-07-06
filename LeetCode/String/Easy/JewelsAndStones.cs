using System.Reflection.Metadata.Ecma335;

namespace LeetCode.String.Easy;

public class JewelsAndStones
{
    /***
      * Tag: Easy
      * Name: 771. Jewels and Stones
      * Start Time: 06/07/2024 15:35 PM
      * End Time: 06/07/2024 15:35 PM
      * Result: 
          * Runtime: solution 1: Beats 93.06% of users with C# ( 37ms )
          * Memory:  solution 1: Beats 70.97% of users with C# ( 38.24MB )
      ***/

    public static void Run()
    {
        string jewels = "aA", stones = "aAAbbbb";
        Console.WriteLine(NumJewelsInStones(jewels, stones));
    }

    public static int NumJewelsInStones(string jewels, string stones)
    {
        return stones.Sum(x => jewels.Contains(x) ? 1: 0);
    }
}

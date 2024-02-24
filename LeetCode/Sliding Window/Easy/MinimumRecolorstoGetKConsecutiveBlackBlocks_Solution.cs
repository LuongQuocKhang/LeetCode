namespace LeetCode.Sliding_Window.Easy;

public class MinimumRecolorstoGetKConsecutiveBlackBlocks_Solution
{
    /***
   * Start Time: 24/02/2024 4:55 PM
   * End Time: 24/02/2024 5:07 PM
   * Result: 
   * Runtime: solution 1: Beats 77.08% of users with C# ( 41ms )
   * Memory:  solution 1: Beats 60.42% of users with C# ( 37.54MB )
   */

    public static void Run()
    {
        string s = "WBBWWBBWBW";
        int k = 7;

        Console.WriteLine(MinimumRecolors(s, k));
    }

    public static int MinimumRecolors(string blocks, int k)
    {
        int min = int.MaxValue;

        for (int i = 0; i < blocks.Length; i++)
        {
            if (i + k > blocks.Length) return min;

            int tryNum = blocks[i..(i + k)].Count(x => x == 'W');

            min = tryNum < min ? tryNum : min ;
        }

        return min;
    }
}

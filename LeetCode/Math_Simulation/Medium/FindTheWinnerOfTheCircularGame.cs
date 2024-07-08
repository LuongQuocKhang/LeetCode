namespace LeetCode.Math_Simulation.Medium;

public class FindTheWinnerOfTheCircularGame
{
    /***
        * Tag: Medium
        * Name: 1823. Find the Winner of the Circular Game
        * Start Time: 08/07/2024 16:15 PM
        * End Time: 08/07/2024 16:35 PM
        * Result: 
            * Runtime: solution 1: Beats 38.46% of users with C# ( 28ms )
            * Memory:  solution 1: Beats 69.23% of users with C# ( 27.65MB )
    ***/

    public static void Run()
    {
        int n = 5, k = 2;
        Console.WriteLine(FindTheWinner(n, k));
    }

    public static int FindTheWinner(int n, int k)
    {
        int index = 0;

        List<int> ints = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            ints.Add(i);
        }

        return Remove(ints, k - 1, index);
    }

    public static int Remove(List<int> ints, int k, int index) {
        if (ints.Count == 1) return ints[0];

        index = (index + k) % ints.Count;

        ints.RemoveAt(index);

        return Remove(ints, k, index);
    }
}
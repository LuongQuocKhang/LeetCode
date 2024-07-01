namespace LeetCode.Arrays.Medium;

public class SubrectangleQueries
{
    /***
     * Tag: Medium
     * Name: 1476. Subrectangle Queries
     * Start Time: 01/07/2023 10:45 AM
     * End Time: 01/07/2023 11:10 AM
     * Result: 
        * Runtime: solution 1: Beats 97.01% of users with C# ( 170ms )
        * Memory:  solution 1: Beats 80.60% of users with C# ( 68.25MB )
    ***/

    private static int[][] rectangle = [[1, 2, 1], [4, 3, 4], [3, 2, 1], [1, 1, 1]];

    public static void Run()
    {
        PrintRectange();

        UpdateSubrectangle(3, 0, 3, 2, 10);

        Console.WriteLine();
        Console.WriteLine();

        PrintRectange();

        Console.WriteLine(GetValue(3,2));
    }

    public static void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
    {
        for (int i = row1; i <= row2; i++)
        {
            for(int j = col1; j <= col2; j++)
            {
                rectangle[i][j] = newValue;
            }
        }
    }

    public static int GetValue(int row, int col)
    {
        return rectangle[row][col];
    }

    private static void PrintRectange()
    {
        for (int i = 0; i < rectangle.Length; i++)
        {
            for (int j = 0; j < rectangle[i].Length; j++)
            {
                Console.Write(rectangle[i][j] + " ");
            }
            Console.WriteLine();
        }

    }
}

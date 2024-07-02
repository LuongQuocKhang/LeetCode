namespace LeetCode.Arrays.Medium;

public static class QueriesOnNumberOfPointsInsideACircle
{
    /***
    * Tag: Medium
    * Name: 1828. Queries on Number of Points Inside a Circle
    * Start Time: 02/07/2023 10:00 AM
    * End Time: 02/07/2023 10:30 AM
    * Result: 
        * Runtime: solution 1: Beats 50.00% of users with C# ( 301ms )
        * Memory:  solution 1: Beats 95.45% of users with C# ( 51.03MB )
    ***/

    public static void Run()
    {
        int[][] points = [[1, 3], [3, 3], [5, 3], [2, 2]], queries = [[2, 3, 1], [4, 3, 1], [1, 1, 2]];

        int[] result = CountPoints(points, queries);

        foreach (int point in result)
        {
            Console.Write(point + " ");
        }
    }

    public static int[] CountPoints(int[][] points, int[][] queries)
    {
        // 1. calculate area of circle for each query
        // center +/- radius
        List<int> result = new List<int>();

        foreach (int[] circle in queries)
        {
            int count = 0;

            foreach (int[] point in points)
            {
                double distance = Math.Sqrt(Math.Pow((point[0] - circle[0]), 2) + Math.Pow((point[1] - circle[1]), 2));

                if (distance <= (double)circle[2]) count++;
            }

            result.Add(count);
        }

        return result.ToArray();
    }
}

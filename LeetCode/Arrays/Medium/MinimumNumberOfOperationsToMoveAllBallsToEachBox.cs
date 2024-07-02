namespace LeetCode.Arrays.Medium;

public static class MinimumNumberOfOperationsToMoveAllBallsToEachBox
{
    /***
    * Tag: Medium
    * Name: 1769. Minimum Number of Operations to Move All Balls to Each Box
    * Start Time: 01/07/2023 18:00 AM
    * End Time: 01/07/2023 18:11 AM
    * Result: 
        * Runtime: solution 1: Beats 41.38% of users with C# ( 161ms )
        * Memory:  solution 1: Beats 10.35% of users with C# ( 50.83MB )
    ***/

    public static void Run()
    {
        int[] result = MinOperations("001011");

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    public static int[] MinOperations(string boxes)
    {
        /***
         * "110"
         * loop through boxes
         * each position find all 1
         * calculate the distance
         */

        List<int> result = new List<int>();

        for (int i = 0; i < boxes.Length; i++)
        {
            int totalDistance = 0;

            for (int j = 0; j < boxes.Length; j++)
            {
                if ( i != j )
                {
                    if (boxes[j] == '1')
                    {
                        totalDistance += Math.Abs(j - i);
                    }
                }

                continue;
            }

            result.Add(totalDistance);
        }

        return result.ToArray();
    }
}

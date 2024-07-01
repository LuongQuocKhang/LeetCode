namespace LeetCode.Arrays.Easy;

public static class FinalValueOfVariableAfterPerformingOperations
{
    /***
        * Name: 1512. Number of Good Pairs
        * Start Time: 01/07/2023 10:05 AM
        * End Time: 01/07/2023 10:15 AM
        * Result: 
            * Runtime: solution 1: Beats 85.11% of users with C# ( 58ms )
            * Memory:  solution 1: Beats 22.70% of users with C# ( 41.68MB )
    ***/

    public static void Run()
    {
        string[] operations = ["--X", "X++", "X++"];

        int result = FinalValueAfterOperations(operations);

        System.Console.WriteLine(result);
    }

    public static int FinalValueAfterOperations(string[] operations)
    {
        return operations.Count(x => x.Contains("++")) - operations.Count(x => x.Contains("--"));
    }
}
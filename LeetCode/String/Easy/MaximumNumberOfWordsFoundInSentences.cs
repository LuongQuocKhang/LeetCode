namespace LeetCode.String.Easy;

public class MaximumNumberOfWordsFoundInSentences
{
    /***
      * Tag: Easy
      * Name: 2114. Maximum Number of Words Found in Sentences
      * Start Time: 06/07/2024 21:05 PM
      * End Time: 06/07/2024 21:06 PM
      * Result: 
          * Runtime: solution 1: Beats 55.13% of users with C# ( 64ms )
          * Memory:  solution 1: Beats 13.69% of users with C# ( 42.75MB )
      ***/

    public static void Run()
    {
        Console.WriteLine(MostWordsFound(["please wait", "continue to fight", "continue to win"]));
    }

    public static int MostWordsFound(string[] sentences)
    {
        // O(N)
        int max = int.MinValue;

        foreach (string sentence in sentences)
        {
            max = Math.Max(max, sentence.Split(" ").Count());
        }

        return max;
    }
}

using System.Linq;

namespace LeetCode.String.Easy;

public class CheckIfTwoStringArraysAreEquivalent
{
    /***
      * Tag: Easy
      * Name: 2942. Split A String In Balanced Strings
      * Start Time: 06/07/2024 21:45 PM
      * End Time: 06/07/2024 22:00 PM
      * Result: 
          * Runtime: solution 1: Beats 41.30% of users with C# ( 71ms )
          * Memory:  solution 1: Beats 89.08% of users with C# ( 42.17MB )
      ***/

    public static void Run()
    {
        string[] word1 = ["a", "cb"], word2 = ["ab", "c"];

        Console.WriteLine(ArrayStringsAreEqual(word1, word2));
    }

    public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string sword1 = string.Join("", word1);
        string sword2 = string.Join("", word2);

        return sword1 == sword2;
    }
}

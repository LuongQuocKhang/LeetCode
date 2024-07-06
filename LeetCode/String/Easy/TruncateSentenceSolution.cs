using System.Text;

namespace LeetCode.String.Easy;

public class TruncateSentenceSolution
{
    /***
      * Tag: Easy
      * Name: 1816. Truncate Sentence
      * Start Time: 06/07/2024 22:00 PM
      * End Time: 06/07/2024 22:07 PM
      * Result: 
          * Runtime: solution 1: Beats 54.93% of users with C# ( 57ms )
          * Memory:  solution 1: Beats 59.62% of users with C# ( 39.26MB )
      ***/

    public static void Run()
    {
        string s = "Hello how are you Contestant";
        int k = 4;

        Console.WriteLine(TruncateSentence(s, k));
    }

    public static string TruncateSentence(string s, int k)
    {
        string[] splited = s.Split(' ');

        return string.Join(" ", splited[..k]);
    }
}

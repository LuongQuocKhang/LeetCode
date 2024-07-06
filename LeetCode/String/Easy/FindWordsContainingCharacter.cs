namespace LeetCode.String.Easy;

public class FindWordsContainingCharacter
{
    /***
      * Tag: Easy
      * Name: 2942. Find Words Containing Character
      * Start Time: 06/07/2024 20:55 PM
      * End Time: 06/07/2024 20:57 PM
      * Result: 
          * Runtime: solution 1: Beats 83.03% of users with C# ( 105ms )
          * Memory:  solution 1: Beats 9.06% of users with C# ( 52.62MB )
      ***/

    public static void Run()
    {
        IList<int> result = FindWordsContaining(["abc", "bcd", "aaaa", "cbc"], 'a');
        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
    }

    public static IList<int> FindWordsContaining(string[] words, char x)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x))
                result.Add(i);
        }

        return result;
    }
}

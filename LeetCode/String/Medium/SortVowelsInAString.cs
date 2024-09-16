using System.Text;

namespace LeetCode.String.Medium;

public class SortVowelsInAString
{
    /***
    * Tag: Medium
    * Name: 2785. Sort Vowels in a String
    * Start Time: 13/07/2024 15:53 PM
    * End Time: 11/07/2024 15:55 PM
    * Result: 
        * Runtime: solution 1: Beats 63.33% of users with C# ( 92ms )
        * Memory:  solution 1: Beats 65.00% of users with C# ( 56.88MB )
    ***/

    public static void Run()
    {
        string s = "lYmpH";

        System.Console.WriteLine(SortVowels(s));
    }


    public static string SortVowels(string s) {
        char[] vowels = [ 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

        // O(n)
        char[] vowelsInS = s.Where(x => vowels.Contains(x)).ToArray();
        
        Array.Sort(vowelsInS);
        int index = 0;

        StringBuilder sb = new StringBuilder();
        // O(n)
        foreach (char c in s)
        {
            if (vowels.Contains(c))
            {
                sb.Append(vowelsInS[index++]);
            }
            else {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}
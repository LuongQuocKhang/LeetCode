using System.Text;

namespace LeetCode.String.Easy;

public class ShuffleString
{
    /***
    * Tag: Easy
    * Name: 1528. Shuffle String
    * Start Time: 07/07/2024 14:39 PM
    * End Time: 07/07/2024 14:50 PM
    * Result: 
        * Runtime: solution 1: Beats 92.39% of users with C# ( 71ms )
        * Memory:  solution 1: Beats 64.13% of users with C# ( 44.73MB )
    ***/

    public static void Run()
    {
        string s = "codeleet";

        int[] indices = [4, 5, 6, 7, 0, 2, 1, 3];

        Console.WriteLine(RestoreString(s, indices));
    }

    public static string RestoreString(string s, int[] indices)
    {
        char[] chars = new char[s.Length];

        for (int i = 0; i < indices.Length; i++)
        {
            chars[indices[i]] = s[i];
        }

        return new string(chars);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String.Easy;

public class ReversePrefixOfWord
{
    /***
      * Tag: Easy
      * Name: 2000. Reverse Prefix of Word
      * Start Time: 06/07/2024 21:40 PM
      * End Time: 06/07/2024 21:41 PM
      * Result: 
          * Runtime: solution 1: Beats 63.53% of users with C# ( 62ms )
          * Memory:  solution 1: Beats 21.39% of users with C# ( 41.81MB )
      ***/

    public static void Run()
    {
        string s = "abcdefd";
        Console.WriteLine(s);
        string result = ReversePrefix(s, 'd');
        Console.WriteLine(result);
    }

    public static string ReversePrefix(string word, char ch)
    {
        int index = word.IndexOf(ch);

        return new string(word[..(index + 1)].ToCharArray().Reverse().ToArray()) + word[(index + 1)..];
    }
}

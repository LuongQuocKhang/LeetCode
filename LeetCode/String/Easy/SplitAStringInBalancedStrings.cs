using System.Text;

namespace LeetCode.String.Easy;

public class SplitAStringInBalancedStrings
{
    /***
      * Tag: Easy
      * Name: 2942. Split A String In Balanced Strings
      * Start Time: 06/07/2024 21:15 PM
      * End Time: 06/07/2024 21:24 PM
      * Result: 
          * Runtime: solution 1: Beats 5.13% of users with C# ( 75ms )
          * Memory:  solution 1: Beats 6.15% of users with C# ( 42.56MB )
      ***/

    public static void Run()
    {
        Console.WriteLine(BalancedStringSplit("RLRRLLRLRL"));
    }

    public static int BalancedStringSplit(string s)
    {
        List<string> list = new List<string>();

        StringBuilder temp = new StringBuilder();
        
        for (int i = 0; i < s.Length - 1; i++)
        {
            temp.Append(s[i]);

            bool isBalanced = false;

            for (int j = i + 1; j < s.Length; j++)
            {
                temp.Append(s[j]);

                isBalanced = checkBalanced(temp.ToString());

                if(isBalanced)
                {
                    list.Add(temp.ToString());
                    i = j;
                    temp = new StringBuilder();
                    break;
                }
            }
        }
        return list.Count;
    }

    private static bool checkBalanced(string s)
    {
        return s.Count(x => x == 'L') == s.Count(x => x == 'R');
    }
}

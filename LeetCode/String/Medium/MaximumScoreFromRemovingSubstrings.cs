using System.Text;

namespace LeetCode.String.Medium;

public class MaximumScoreFromRemovingSubstrings
{
    /***
    * Tag: Medium
    * Name: 1717. Maximum Score From Removing Substrings
    * Start Time: 12/07/2024 18:00 PM
    * End Time: 12/07/2024 19:58 PM
    * Result: 
        * Runtime: solution 1: Beats 54.55% of users with C# ( 88ms )
        * Memory:  solution 1: Beats 9.09% of users with C# ( 52.13MB )
    ***/

    public static void Run()
    {
        string s = "aabbaaxybbaabb";
        int x = 5, y = 4;

        System.Console.WriteLine(MaximumGain(s, x, y));
    }

    public static int MaximumGain(string s, int x, int y)
    {
        char a = 'a';
        char b = 'b';
        if(y > x) {
            (a, b) = (b, a);
            (x, y) = (y, x);
        }
        
        int score = 0;
        var forwardStack = new Stack<char>();
        foreach (var ch in s)
            if(forwardStack.Count != 0 && ch == b && forwardStack.Peek() == a) {
                score += x;
                forwardStack.Pop();
            }
            else forwardStack.Push(ch);
        
        var reverseStack = new Stack<char>();
        while (forwardStack.Count != 0)
            if(reverseStack.Count != 0 && reverseStack.Peek() == a && forwardStack.Peek() == b) { 
                score += y;
                forwardStack.Pop();
                reverseStack.Pop();
            } else reverseStack.Push(forwardStack.Pop());

        return score;
    }
}
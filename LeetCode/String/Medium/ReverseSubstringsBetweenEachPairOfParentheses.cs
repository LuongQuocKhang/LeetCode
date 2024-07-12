
using System.Text;

namespace LeetCode.String.Medium;

public class ReverseSubstringsBetweenEachPairOfParentheses
{
    /***
    * Tag: Medium
    * Name: 1190. Reverse Substrings Between Each Pair of Parentheses
    * Start Time: 11/07/2024 9:45 AM
    * End Time: 11/07/2024 9:40 AM
    * Result: 
        * Runtime: solution 1: Beats 35.90% of users with C# ( 59ms )
        * Memory:  solution 1: Beats 25.64% of users with C# ( 39.56MB )
    ***/

    public static void Run()
    {
        string s = "(ed(et(oc))el)";

        System.Console.WriteLine(ReverseParentheses(s));
    }

    public static string ReverseParentheses(string s) 
    {
        Stack<char> stack = new Stack<char>();

        foreach(char c in s)
        {
            if (c == ')')
            {
                StringBuilder sbStack = new StringBuilder();

                while(true) {
                    char cp = stack.Pop();
                    
                    if(cp == '(') {

                        string reversed = sbStack.ToString();

                        foreach (char reverseChar in reversed)
                        {
                            stack.Push(reverseChar);
                        }

                        break;
                    }

                    sbStack.Append(cp);
                }
            }
            else {
                stack.Push(c);
            }
            
        }

        StringBuilder sb = new StringBuilder();

        char[] charArray = stack.ToArray();

        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            sb.Append(charArray[i]);
        }

        return sb.ToString();
    }

}
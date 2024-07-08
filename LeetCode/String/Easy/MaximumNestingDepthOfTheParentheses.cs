namespace LeetCode.String.Easy;

public class MaximumNestingDepthOfTheParentheses
{

    /***
        * Tag: Easy
        * Name: 1614. Maximum Nesting Depth of the Parentheses
        * Start Time: 08/07/2024 14:30 PM
        * End Time: 08/07/2024 15:05 PM
        * Result: 
            * Runtime: solution 1: Beats 85.31% of users with C# ( 40ms )
            * Memory:  solution 1: Beats 6.64% of users with C# ( 37.72MB )
    ***/

    public static void Run()
    {
        System.Console.WriteLine(MaxDepth("(1+(2*3)+((8)/4))+1"));
    }

    public static int MaxDepth(string s)
    {
        // loop through s
        // if s[i] == ( => push to stack => reset count
        // if s[i] == ) => pop from stack => depth + 1
        Stack<char> stack = new Stack<char>();
        int count = 0;
        int result = 0;
        foreach (char c in s)
        {
            if (c == '(')
            {
                stack.Push(c);
                count++;
            }
            else if (c == ')')
            {
                char parentheses = stack.Pop();
                if (parentheses != '\0')
                {
                    if(count > result) {
                        result = count;
                    }
                    count--;
                    
                }
            }
        }
        return result;
    }
}
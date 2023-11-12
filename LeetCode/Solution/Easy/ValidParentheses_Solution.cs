namespace LeetCode.Solution.Easy;

public class ValidParentheses_Solution
{
    public static void Run()
    {
        Console.WriteLine(IsValid("{}(P){}"));
    }

    public static bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0) return false;

                char top = stack.Pop();

                if (c == ')')
                {
                    if (top != '(')
                    {
                        return false;
                    }
                }

                if (c == ']')
                {
                    if (top != '[')
                    {
                        return false;
                    }
                }

                if (c == '}')
                {
                    if (top != '{')
                    {
                        return false;
                    }
                }
            }
        }

        if (stack.Count > 0)
        {
            return false;
        }

        return true;
    }
}

namespace LeetCode.Solution.Easy;

public class PalindromeNumber_Solution
{
    public static void Run()
    {
        Console.WriteLine(IsPalindrome(12321));
    }

    public static bool IsPalindrome(int x)
    {
        string text = x.ToString();
        char[] textarray = text.ToCharArray();
        Array.Reverse(textarray);
        string reversedText = new string(textarray);
        // GC.Collect();
        return text == reversedText;
    }
}

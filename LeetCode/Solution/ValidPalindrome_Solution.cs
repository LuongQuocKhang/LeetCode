using System.Text.RegularExpressions;

namespace LeetCode.Solution;

public class ValidPalindrome_Solution
{
    public static void Run()
    {
        Console.WriteLine(IsPalindrome("141242412-345634"));
    }

    public static bool IsPalindrome(string s)
    {
        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
        s = s.ToLower();
        s = rgx.Replace(s, "").Replace(" ", "").Replace("-", "");

        char[] chars = s.ToCharArray();
        Array.Reverse(chars);

        string newString = new string(chars);

        return s == newString;
    }
}

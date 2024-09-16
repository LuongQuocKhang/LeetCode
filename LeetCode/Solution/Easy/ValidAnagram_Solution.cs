namespace LeetCode.Solution.Easy;

public class ValidAnagram_Solution
{
    public static void Run()
    {
        Console.WriteLine(IsAnagram("12312", "5345345"));
    }

    public static bool IsAnagram(string s, string t)
    {
        if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t)) return true;
        if (s.Length != t.Length) return false;

        char[] chars = s.ToCharArray();
        char[] chart = t.ToCharArray();

        Array.Sort(chart);
        Array.Sort(chars);

        return new string(chars) == new string(chart);
    }
}

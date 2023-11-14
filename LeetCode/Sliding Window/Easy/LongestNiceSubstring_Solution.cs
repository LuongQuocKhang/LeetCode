namespace LeetCode.Sliding_Window.Easy;

public class LongestNiceSubstring_Solution
{
    public static void Run()
    {
        Console.WriteLine(LongestNiceSubstring("YazaAay"));
    }

    public static string LongestNiceSubstring(string s)
    {
        List<string> list = new List<string>();

        string result = "";

        for (int end = 0; end < s.Length; end++)
        {
            result += s[end];


        }

        return result;
    }
}

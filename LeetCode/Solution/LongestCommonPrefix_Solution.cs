namespace LeetCode.Solution;

public class LongestCommonPrefix_Solution : ISolution
{
    public void Run()
    {
        string[] strs = { "flower", "flow", "flight" };
        LongestCommonPrefix(strs);
    }

    public string LongestCommonPrefix(string[] strs)
    {
        var commonPrefix = new List<string>();
        if (strs.Length > 0)
        {
            string firstString = strs[0];
            string checkString = "";
            for (int i = 0; i < firstString.Length; i++)
            {
                checkString = string.Concat(checkString, firstString[i]);
                bool valid = strs.All(x => x.Contains(checkString));
                if (valid)
                {
                    commonPrefix.Add(checkString);
                }
            }
        }

        var longestCommonPrefix = commonPrefix.Where(x => strs.All(y => y.StartsWith(x))).OrderByDescending(x => x.Length).FirstOrDefault();
        return longestCommonPrefix ?? string.Empty;
    }
}

namespace LeetCode.Arrays.Medium;

public class GroupAnagramsSolution
{
    /***
    * Tag: Medium
    * Name: 1717. Maximum Score From Removing Substrings
    * Start Time: 12/07/2024 19:58 PM
    * End Time: 12/07/2024 19:00 PM
    * Result: 
        * Runtime: solution 1: Beats 5.02% of users with C# ( 1063ms )
        * Memory:  solution 1: Beats 5.02% of users with C# ( 131.02MB )
    ***/

    public static void Run()
    {
        string[] strs = ["","b"];
        IList<IList<string>> list = GroupAnagrams(strs);
    }

    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        List<IList<string>> result = new List<IList<string>>();

        List<int> visited = new List<int>();

        for (int i = 0; i < strs.Length; i++)
        {
            if(visited.Contains(i)) continue;

            List<string> list = new List<string>(){
                strs[i]
            };

            if (i < strs.Length - 1)
            {
                for (int j = i + 1; j < strs.Length; j++)
                {
                    if (IsAnagram(strs[i], strs[j]))
                    {
                        list.Add(strs[j]);
                        visited.Add(j);
                    }
                }

            }

            result.Add(list);
        }
        return result;
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
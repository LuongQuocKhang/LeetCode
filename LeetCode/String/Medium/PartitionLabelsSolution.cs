using System.Text;

namespace LeetCode.String.Medium;
public class PartitionLabelsSolution
{
    /***
    * Tag: Medium
    * Name: 763. Partition Labels
    * Start Time: 13/07/2024 16:55 PM
    * End Time: 11/07/2024 15:55 PM
    * Result: 
        * Runtime: solution 1: Beats 63.33% of users with C# ( 92ms )
        * Memory:  solution 1: Beats 65.00% of users with C# ( 56.88MB )
    ***/

    public static void Run()
    {
        string s = "ababcbacadefegdehijhklij";

        IList<int> ints = PartitionLabels(s);

        foreach (int item in ints)
        {
            System.Console.Write(item + " ");
        }
    }

    public static IList<int> PartitionLabels(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        List<string> strings = new List<string>();

        StringBuilder sb = new StringBuilder();

        foreach (char c in s)
        {
            if (!dict.ContainsKey(c))
            {
                dict.Add(c, 1);
                sb.Append(c);
            }
            else
            {
                strings.Add(sb.ToString());
                sb = new StringBuilder();
                dict = new Dictionary<char, int>();
            }
        }

        return strings.Select(x => x.Length).ToList();
    }
}
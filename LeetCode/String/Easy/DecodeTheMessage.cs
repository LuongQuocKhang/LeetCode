using System.Text;

namespace LeetCode.String.Easy;

public class DecodeTheMessage
{
    /***
    * Tag: Easy
    * Name: 2325. Decode the Message
    * Start Time: 08/07/2024 10:45 AM
    * End Time: 08/07/2024 10:50 AM
    * Result: 
        * Runtime: solution 1: Beats 5.34% of users with C# ( 120ms )
        * Memory:  solution 1: Beats 48.85% of users with C# ( 47.47MB )
    ***/

    public static void Run()
    {
        string key = "the quick brown fox jumps over the lazy dog", 
            message = "vkbs bs t suepuv";

        Console.WriteLine(DecodeMessage(key, message));
    }

    public static string DecodeMessage(string key, string message)
    {
        Dictionary<char, char> map = new Dictionary<char, char>();

        // a (97) -> z (122)
        int start = 97;
        foreach (char c in key)
        {
            if (map.Values.Any(x => x == c))
                continue;

            if (c != ' ')
            {
                map.Add((char)start, c);
                start++;
            }
        }

        StringBuilder sb = new StringBuilder();

        foreach (char c in message)
        {
            if(c != ' ') {
                char mapKey = map.Keys.First(key => map[key] == c);
                sb.Append(mapKey);
            }
            else {
                sb.Append(' ');
            }
        }

        return sb.ToString();
    }
}
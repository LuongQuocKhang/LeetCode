using Microsoft.VisualBasic;

namespace LeetCode.Arrays.Easy;

public class CrawlerLogFolder
{
    /***
    * Tag: Easy
    * Name: 1598. Crawler Log Folder
    * Start Time: 09/07/2024 9:30 AM
    * End Time: 09/07/2024 9:35 PM
    * Result: 
        * Runtime: solution 1: Beats 83.56% of users with C# ( 53ms )
        * Memory:  solution 1: Beats 97.26% of users with C# ( 40.14MB )
    ***/

    public static void Run()
    {
        string[] logs = ["./","wz4/","../","mj2/","../","../","ik0/","il7/"];

        System.Console.WriteLine(MinOperations(logs));
    }

    public static int MinOperations(string[] logs)
    {
        int result = 0;

        foreach (string log in logs)
        {
            if (log == "../")
            {
                if(result > 0)
                {
                    result--;
                }
                else {
                    result = 0;
                }
                continue;
            }
            if (log == "./") continue;

            result++;
        }

        return result > 0 ? result : 0;
    }
}
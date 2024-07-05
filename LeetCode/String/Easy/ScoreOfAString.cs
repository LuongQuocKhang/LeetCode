using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String.Easy;

public class ScoreOfAString
{
    /***
    * Tag: Medium
    * Name: 1828. Queries on Number of Points Inside a Circle
    * Start Time: 04/07/2024 18:24 PM
    * End Time: 04/07/2024 10:30 PM
    * Result: 
        * Runtime: solution 1: Beats 90.47% of users with C# ( 38ms )
        * Memory:  solution 1: Beats 83.58% of users with C# ( 38.51MB )
    ***/

    public static void Run()
    {
        Console.WriteLine(ScoreOfString("hello"));
    }

    public static int ScoreOfString(string s)
    {
        int total = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (i + 1 < s.Length)
            {
                total += Math.Abs((int)s[i] - (int)s[i + 1]);
            }
        }
        return total;
    }
}

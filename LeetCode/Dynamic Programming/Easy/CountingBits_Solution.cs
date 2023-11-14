namespace LeetCode.Dynamic_Programming.Easy;

public class CountingBits_Solution
{
    /**
    Input: n = 5
    Output: [0,1,1,2,1,2]
    Explanation:
    0 --> 0
    1 --> 1
    2 --> 10
    3 --> 11
    4 --> 100
    5 --> 101
    **/

    /***
     * Start Time: 14/11/2023 11:54 PM
     * End Time:14/11/2023 11:58 PM
     * Result: 
     * Runtime: Beats 5.07%of users with C# ( 132ms )
     * Memory: Beats 5.19%of users with C# ( 78.59MB )
     * Need to search more effecient solution
     */


    public static void Run()
    {
        int num = 5;
        int[] result = CountBits(num);

        string results = string.Join(",", result);

        Console.WriteLine("[" + results + "]");
    }

    public static int[] CountBits(int n)
    {
        int[] result = new int[n + 1];

        for (int i = 0; i <= n; i++)
        {
            int sum = 0;
            // convert to binary
            string binary = Convert.ToString(i, 2);
            // sum of binary

            sum = binary.Sum(x => int.Parse(x.ToString()));

            result[i] = sum;
        }

        return result;
    }
}

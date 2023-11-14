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
     * Runtime: solution 1. Beats 5.07%of users with C# ( 132ms )
     *          solution 2. Beats 64.15%of users with C# (90ms)
     * Memory:  solution 1 Beats 5.19%of users with C# ( 78.59MB )
     *          solution 2: Beats 40.80%of users with C# ( 39.78MB )
     * Need to search more effecient solution
     */


    public static void Run()
    {
        int num = 5;
        int[] result = CountBits_2(num);

        string results = string.Join(",", result);

        Console.WriteLine("[" + results + "]");
    }

    public static int[] CountBits_2(int n)
    {
        int[] result = new int[n + 1];

        for (int i = 0; i <= n; i++)
        {
            int num = i, sum = 0;

            while(num != 0)
            {
                sum += (num % 2);
                num /= 2;
            }
            result[i] = sum;
        }

        return result;
    }

    public static int[] CountBits_1(int n)
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

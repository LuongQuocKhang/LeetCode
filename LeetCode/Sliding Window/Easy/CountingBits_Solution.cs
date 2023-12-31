﻿namespace LeetCode.Sliding_Window.Easy;

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
     * Start Time: 14/11/2023 11:54 AM
     * End Time: 14/11/2023 11:58 AM
     * Result: 
     * Runtime: solution 1. 
     *          solution 2. 
     * Memory:  solution 1 
     *          solution 2: 
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

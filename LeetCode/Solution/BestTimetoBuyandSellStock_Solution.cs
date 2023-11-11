namespace LeetCode.Solution;

public class BestTimetoBuyandSellStock_Solution
{
    public static void Run()
    {
        int[] nums = { 2, 0, 2, 1, 1, 0 };
        MaxProfit(nums);
    }

    public static int MaxProfit(int[] prices)
    {
        int minProfit = int.MaxValue,
            maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            minProfit = Math.Min(minProfit, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - minProfit);
        }

        return maxProfit;
    }
}

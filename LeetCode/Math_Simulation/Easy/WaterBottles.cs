namespace LeetCode.Math_Simulation.Easy;

public class WaterBottles
{
    /***
    * Tag: Easy
    * Name: 1518. Water Bottles
    * Start Time: 07/07/2024 16:20 PM
    * End Time: 07/07/2024 16:25 PM
    * Result: 
        * Runtime: solution 1: Beats 32.50% of users with C# ( 23ms )
        * Memory:  solution 1: Beats 10.00% of users with C# ( 26.93MB )
    ***/

    public static void Run()
    {
        int numBottles = 15, numExchange = 4;

        Console.WriteLine(NumWaterBottles(numBottles, numExchange));
    }

    public static int NumWaterBottles(int numBottles, int numExchange)
    {
        int total = numBottles;

        while (true)
        {
            int exchange = numBottles / numExchange;
            int change = numBottles % numExchange;

            if (exchange == 0 && change < numExchange)
            {
                break;
            }

            numBottles = exchange + change;

            total += exchange;
        }
        return total;
    }
}

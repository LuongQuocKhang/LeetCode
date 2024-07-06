namespace LeetCode.Math_Simulation.Easy;

public class PassThePillowSolution
{
    /***
    * Tag: Easy
    * Name: 2582. Pass the Pillow
    * Start Time: 06/07/2024 14:14 AM
    * End Time: 06/07/2024 14:16 PM
    * Result: 
       * Runtime: solution 1: Beats 95.65% of users with C# ( 12ms )
       * Memory:  solution 1: Beats 56.52% of users with C# ( 26.83MB )
   ***/
    public static void Run()
    {
        int n = 1000, time = 1000;
        
        Console.WriteLine(PassThePillow(n, time));
    }
     
    public static int PassThePillow(int n, int time)
    {
        if (n > time)
        {
            return time;
        }

        int curernt = 1;

        bool hitEnd = false;

        int count = 0;

        while (true)
        {
            if (curernt == n)
            {
                hitEnd = true;
            }

            if (hitEnd)
            {
                curernt--;
            }
            else
            {
                curernt++;
            }

            count++;

            if (count == time) break;

            if (curernt == 1 && hitEnd)
            {
                hitEnd = false;
            }
        }

        return curernt;
    }
}



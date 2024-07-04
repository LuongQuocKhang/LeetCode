namespace LeetCode.Arrays.Medium;

public class NumberOfLaserBeamsInABank
{
    /***
    * Tag: Medium
    * Name: 2125. Number of Laser Beams in a Bank
    * Start Time: 04/07/2024 13:15 PM
    * End Time: 04/07/2024 13:25 AM
    * Result: 
       * Runtime: solution 1: Beats 15.44% of users with C# ( 154ms )
       * Memory:  solution 1: Beats 14.71% of users with C# ( 52.69MB )
   ***/
    public static void Run()
    {
        string[] bank = ["011001", "000000", "010100", "001000"];

        Console.WriteLine(NumberOfBeams(bank));
    }

    public static int NumberOfBeams(string[] bank)
    {
        // "011001"
        // "000000"
        // "010100"

        int result = 0;

        int length = bank.Length;

        for (int i = 0; i < length - 1; i++)
        {
            for (int j = i + 1; j < length; j++ ) 
            {
                if (!bank[j].Contains('1') || !bank[i].Contains('1'))
                {
                    continue;
                }

                result += bank[i].Count(x => x == '1') * bank[j].Count(x => x == '1');

                break;
            }
        }

        return result;
    }
}

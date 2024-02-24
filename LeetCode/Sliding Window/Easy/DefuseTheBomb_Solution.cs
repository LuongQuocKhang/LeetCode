namespace LeetCode.Sliding_Window.Easy;

public static class DefuseTheBomb_Solution
{
    /***
   * Start Time: 24/02/2024 4:00 PM
   * End Time: 24/02/2024 4:53 PM
   * Result: 
   * Runtime: solution 1: Beats 60.61% of users with C# ( 101ms )
   * Memory:  solution 1: Beats 19.70% of users with C# ( 46.38MB )
   */

    public static void Run()
    {
        int[] nums = { 2, 4, 9, 3 };
        int k = -2;

        Console.WriteLine(string.Join(",", nums));

        int[] results = Decrypt(nums, k);

        Console.WriteLine(string.Join(",", results));
    }
    public static int[] Decrypt(int[] code, int k)
    {
        if (k == 0) return code.Select(x => 0).ToArray();

        List<int> result = [];

        for (int i = 0; i < code.Length; i++)
        {
            if (k > 0)
            {
                int num = 0;
                for (int j = i + 1; j <= i + k; j++)
                {
                    num += GetNextNum(code, j);
                }
                result.Add(num);
            }
            else
            {
                int numberOfK = k * (-1);

                int num = 0;

                for (int j = i; j > i - numberOfK; j--)
                {
                    num += GetPreviousNum(code, j);
                }

                result.Add(num);
            }
        }

        return result.ToArray();
    }
    private static int GetNextNum(int[] code, int currentIndex)
    {
        return code[currentIndex % code.Length];
    }

    private static int GetPreviousNum(int[] code, int currentIndex)
    {
        int previousIndex = (currentIndex - 1 + code.Length) % code.Length;
        int previousValue = code[previousIndex];

        return previousValue;
    }
}

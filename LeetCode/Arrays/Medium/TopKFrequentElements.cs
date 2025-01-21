namespace LeetCode.Arrays.Medium;

internal class TopKFrequentElements
{
    /***
    * Tag: Medium
    * Name: 347. Top K Frequent Elements
    * Start Time: 18/01/2025 11:17 AM
    * End Time: 18/01/2025 11:20 AM
    * Time Complexity: O(N + K)
    * Result: 
        * Runtime: solution 1: Beats 5.06% of users with C# ( 155ms )
        * Memory:  solution 1: Beats 16.77% of users with C# ( 51.94MB )
    ***/

    public static void Run()
    {
        int[] nums = [1, 1, 1, 2, 2, 3];
        int k = 2;
        int[] result = TopKFrequent(nums, k);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    public static int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.TryGetValue(num, out int value))
            {
                dict[num] = ++value;
            }
            else
            {
                dict.Add(num, 1);
            }
        } // O(N)

        HashSet<int> result = new HashSet<int>();

        // O(k)
        for (int i = 0; i < k; i++)
        {
            int max = dict.Values.Max();
            int key = dict.FirstOrDefault(x => x.Value == max).Key;
            result.Add(key);
            dict.Remove(key);
        }
        // => O(N + K)
        return result.ToArray();
    }
}

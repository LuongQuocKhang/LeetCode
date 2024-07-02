namespace LeetCode.Arrays.Easy;

public static class IntersectionOfTwoArraysII
{
    /***
       * Tag: Easy
       * Name: 350. Intersection of Two Arrays II
       * Start Time: 02/07/20203 09:36 AM
       * End Time: 02/07/2023 9:55 AM
       * Result: 
           * Runtime: solution 1: Beats 76.76% of users with C# ( 101ms )
           * Memory:  solution 1: Beats 62.99% of users with C# ( 46.72MB )
   ***/
    public static void Run()
    {
        int[] nums1 = [3, 1, 2], nums2 = [1, 1];

        foreach (int i in nums1)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        foreach (int i in nums2)
        {
            Console.Write(i + " ");
        }

        int[] result = Intersect(nums1, nums2);


        Console.WriteLine();

        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
    }

    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        List<int> visited = new List<int>();
        List<int> result = new List<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if(nums1[i] == nums2[j] && !visited.Contains(j))
                {
                    visited.Add(j);
                    result.Add(nums1[i]);
                    break;
                }
            }
        }

        return result.ToArray();
    }
}

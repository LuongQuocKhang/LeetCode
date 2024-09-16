namespace LeetCode.Sort;

public class QuickSort
{
    private static int[] Execute(int[] unorderedArray)
    {
        if (unorderedArray.Length < 2)
            return unorderedArray;

        int pivot = unorderedArray[0];

        List<int> lesser = [];
        List<int> greater = [];

        for (int i = 1; i < unorderedArray.Length; i++)
        {
            if (unorderedArray[i] < pivot)
            {
                lesser.Add(unorderedArray[i]);
            }
            else
            {
                greater.Add(unorderedArray[i]);
            }
        } // O(N)

        int[] sortedLess = Execute([.. lesser]); // O(logN)
        int[] sortedGreater = Execute([.. greater]); // O(logN)

        return [.. sortedLess, pivot, .. sortedGreater];
    }
}

namespace LeetCode.Arrays.Easy;

public class ConcatenationOfArray
{
    public static void Run()
    {
        int[] nums = [1, 3, 2, 1];

        int[] result = GetConcatenation(nums);

        foreach(int i in result)
        {
            Console.Write(i + " ");
        }
    }

    public static int[] GetConcatenation(int[] nums)
    {
        return [.. nums, .. nums];
    }
}

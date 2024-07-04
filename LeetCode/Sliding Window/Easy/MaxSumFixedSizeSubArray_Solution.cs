namespace LeetCode.Learning.Sliding_Window
{
    /***
     * [ 4, 2, 1, 7, 8, 1, 2, 8, 1, 0 ]
     */

    public class MaxSumFixedSizeSubArray_Solution
    {
        public static void Run()
        {
            int[] nums = { 4, 2, 1, 7, 8, 3, 2, 8, 1, 0 };

            int numberOfSum = 3;

            Console.WriteLine(MaxSumArray(nums, numberOfSum));
        }

        public static int MaxSumArray(int[] nums, int numberOfSum)
        {
            int max = int.MinValue;
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];

                // 4 -> 6 -> 7 ( i = 2 )
                // ( i = 3 ) -> remove i = 0

                if(i >= numberOfSum - 1)
                {
                    max = Math.Max(max, currentSum);
                    currentSum -= nums[i - (numberOfSum - 1)]; // remove 4 -> currentSum = 3
                }
            }

            return max;
        }
    }
}

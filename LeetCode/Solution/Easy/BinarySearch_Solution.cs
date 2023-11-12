using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution.Easy
{
    public class BinarySearch_Solution
    {
        public static void Run()
        {
            int[] nums = { 1, 2, 3, 4 };
            Console.WriteLine(Search(nums, 4));
        }

        public static int Search(int[] nums, int target)
        {
            return BinarySearch(nums, target);
        }

        public static int BinarySearch(int[] nums, int target, int index = 0)
        {
            if (nums == null || nums.Length == 0) return -1;

            int indexMid = nums.Length / 2;

            int mid = nums[indexMid];

            if (mid == target) return index + indexMid;

            if (indexMid == 0) return -1;

            if (target < mid)
            {
                return BinarySearch(nums[0..indexMid], target, index);
            }
            else
            {
                return BinarySearch(nums[indexMid..], target, indexMid + index);
            }
        }
    }
}

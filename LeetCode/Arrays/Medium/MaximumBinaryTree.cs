namespace LeetCode.Arrays.Medium;

public class MaximumBinaryTree
{
    /***
    * Tag: Medium
    * Name: 654. Maximum Binary Tree
    * Start Time: 04/07/2024 14:40 PM
    * End Time: 04/07/2024 14:45 AM
    * Result: 
       * Runtime: solution 1: Beats 5.81% of users with C# ( 122ms )
       * Memory:  solution 1: Beats 10.46% of users with C# ( 57.25MB )
   ***/
    public static void Run()
    {
        int[] nums = [3, 2, 1, 6, 0, 5];

        TreeNode result = ConstructMaximumBinaryTree(nums);
    }

    public static TreeNode ConstructMaximumBinaryTree(int[] nums)
    {
        // find max => root
        // subarray left => build tree
        // subarray right => build tree
        // combine to root

        if (nums.Length == 0) return null;
        int max = nums.Max();

        TreeNode root = new TreeNode(max);

        int indexOfMax = Array.IndexOf(nums, max);
        int[] leftSubArray = nums[0..indexOfMax]; // left
        int[] rightSubArray = nums[(indexOfMax + 1)..(nums.Length)]; // right

        root.val = max;
        root.left = ConstructMaximumBinaryTree(leftSubArray);
        root.right = ConstructMaximumBinaryTree(rightSubArray);

        return root;
    }
}

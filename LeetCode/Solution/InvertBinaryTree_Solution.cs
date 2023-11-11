
namespace LeetCode.Solution;

public class InvertBinaryTree_Solution
{
    public static void Run()
    {
        InvertTree(new TreeNode());
    }

    public static TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return root;

        TreeNode node = new TreeNode(root.val);

        TreeNode leftNode = root.left;
        TreeNode rightNode = root.right;

        TreeNode tempNode = null;

        tempNode = leftNode;
        leftNode = rightNode;
        rightNode = tempNode;

        if (leftNode != null)
        {
            leftNode = InvertTree(leftNode);
        }

        if (rightNode != null)
        {
            rightNode = InvertTree(rightNode);
        }

        node.left = leftNode;
        node.right = rightNode;

        return node;
    }
}

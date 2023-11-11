using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution;


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}


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

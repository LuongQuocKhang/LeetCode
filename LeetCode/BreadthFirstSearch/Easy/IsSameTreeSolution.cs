namespace LeetCode.BreadthFirstSearch.Easy;

/***
* Tag: Easy
* Name: 1684. Count the Number of Consistent Strings
* Start Time: 16/09/2024 17:45 PM
* End Time: 16/09/2024 17:48 PM
* Time Complexity: O(N)
* Result:
	* Runtime: solution 1: Beats 75.03% of users with C# ( 65ms )
	* Memory:  solution 1: Beats 42.28% of users with C# ( 42.48MB )
***/

public class IsSameTreeSolution
{
    public static void Run()
    {
        TreeNode p = new TreeNode(1,
            new TreeNode(2), null);
        TreeNode q = new TreeNode(1,
            null, new TreeNode(2));

        Console.WriteLine(IsSameTree(p, q));
    }

    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        // O(N) => loop through all node
        List<int?> firstTree = TraverseGraph(p);
        List<int?> secondTree = TraverseGraph(q);

        foreach (int? item in firstTree)
        {
            System.Console.Write(item + " ");
        }
        Console.WriteLine();
        foreach (int? item in secondTree)
        {
            System.Console.Write(item + " ");
        }

        if (firstTree.Count != secondTree.Count) return false;

        // O(N) 
        for (int i = 0; i < firstTree.Count; i++)
        {
            if (firstTree[i] != secondTree[i]) return false;
        }

        return true;
    }

    private static List<int?> TraverseGraph(TreeNode p)
    {
        List<int?> result = new List<int?>();

        Queue<TreeNode?> queue = new Queue<TreeNode?>();

        queue.Enqueue(p);

        while (queue.Count > 0)
        {
            TreeNode? node = queue.Dequeue();

            if (node == null)
            {
                result.Add(null);
            }
            else
            {
                result.Add(node.val);
            }

            if (node == null)
            {
                continue;
            }

            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }

        return result;
    }
}

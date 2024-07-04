namespace LeetCode.LinkedList.Easy;

public static class MergeNodesInBetweenZeros
{
    /***
     * Tag: Medium
     * Name: 2181. Merge Nodes in Between Zeros
     * Start Time: 04/07/2024 11:42 AM
     * End Time: 04/07/2024 12:00 PM
     * Result: 
        * Runtime: solution 1: Beats 14.81% of users with C# ( 669ms )
        * Memory:  solution 1: Beats 5.56% of users with C# ( 135.12MB )
    ***/


    public static void Run()
    {
        ListNode head = new ListNode()
        {
            val = 0,
            next = new ListNode()
            {
                val = 3,
                next = new ListNode()
                {
                    val = 1,
                    next = new ListNode()
                    {
                        val = 0,
                        next = new ListNode()
                        {
                            val = 4,
                            next = new ListNode()
                            {
                                val = 5,
                                next = new ListNode()
                                {
                                    val = 2,
                                    next = new ListNode()
                                    {
                                        val = 0,
                                        next = null
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };
        ListNode result = MergeNodes(head);

        ListNode node = result;
        while (true)
        {
            Console.WriteLine(node.val);

            if (node.next == null)
                break;
            node = node.next;
        }
    }

    public static ListNode MergeNodes(ListNode head)
    {
        ListNode node = head;

        List<int> merged = new List<int>();

        int sum = 0;

        bool first = true;

        while (true)
        {
            if (node == null) break;

            if (first)
            {
                node = node.next;
                first = false;
                continue;
            }

            if (node.val == 0)
            {
                merged.Add(sum);

                sum = 0;

                node = node.next;

                continue;
            }

            sum += node.val;

            if (node.next == null)
            {
                break;
            }

            node = node.next;
        }

        ListNode result = new ListNode();

        return BuildNode(new ListNode(), merged, 0);
    }

    private static ListNode BuildNode(ListNode root, List<int> mergeValue, int index)
    {
        if (index == mergeValue.Count)
            return null;
        root.val = mergeValue[index];
        index++;
        root.next = BuildNode(new ListNode(), mergeValue, index);

        return root;
    }
}

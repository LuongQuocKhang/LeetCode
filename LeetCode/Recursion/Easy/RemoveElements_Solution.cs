namespace LeetCode.Recursion.Easy;

public class RemoveElements_Solution
{
    /***
    * Tag: Easy
    * Name: 326. Power of Three
    * Start Time: 17/01/2025 1:45 PM
    * End Time: 17/01/2025 10:00 AM
    * Time Complexity: O(N)
    * Result: 
        * Runtime: solution 1: Beats 11.84% of users with C# ( 1ms )
        * Memory:  solution 1: Beats 7.40% of users with C# ( 49.20MB )
    ***/

    public static void Run()
    {
        ListNode node = new ListNode(7, 
            new ListNode(7,
            new ListNode(7)));
        int val = 7;

        var newNode = RemoveElements(node, val);
        ListNode iterateNode = newNode;
        while (true)
        {
            
            System.Console.WriteLine(iterateNode.val);

            if (iterateNode.next == null)
            {
                break;
            }

            iterateNode = iterateNode.next;
        }
        
    }

    public static ListNode RemoveElements(ListNode head, int val)
    {
        ListNode node = new ListNode(-1);

        node.next = head;

        var current = node;

        while (current.next != null)
        {
            if (current.next.val == val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return node.next;
    }
}
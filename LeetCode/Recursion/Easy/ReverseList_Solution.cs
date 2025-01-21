namespace LeetCode.Recursion.Easy;

internal class ReverseList_Solution
{
    /***
    * Tag: Easy
    * Name: 206. Reverse Linked List
    * Start Time: 17/01/2025 4:10 PM
    * End Time: 17/01/2025 4:30 PM
    * Result: 
        * Runtime: solution 1: Beats 4.37% of users with C# ( 1ms )
        * Memory:  solution 1: Beats 7.40% of users with C# ( 49.20MB )
    ***/

    public static void Run()
    {
        ListNode node = new ListNode(1,
            new ListNode(2,
            new ListNode(3)));

        var newNode = ReverseList(node);
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

    public static ListNode ReverseList(ListNode head)
    {
        // current
        // 1 -> 2 -> 3 -> 4 -> 5 -> null

        ListNode prev = null;
        ListNode current = head;

        while(current != null)
        {
            ListNode tempNext = current.next;
            current.next = prev;
            prev = current;
            current = tempNext;
        }

        return prev;
    }

}

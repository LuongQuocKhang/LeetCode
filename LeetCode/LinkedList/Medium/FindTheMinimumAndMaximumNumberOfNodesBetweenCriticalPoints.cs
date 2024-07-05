namespace LeetCode.LinkedList.Medium;

public class FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints
{
    /***
     * Tag: Medium
     * Name: 2181. Merge Nodes in Between Zeros
     * Start Time: 05/07/2024 11:20 AM
     * End Time: 05/07/2024 18:15 PM
     * Result: 
        * Runtime: solution 1: Beats 75.00% of users with C# ( 408ms )
        * Memory:  solution 1: Beats 41.67% of users with C# ( 106.08MB )
    ***/

    public static void Run()
    {
        ListNode head = new ListNode()
        {
            val = 6,
            next = new ListNode()
            {
                val = 8,
                next = new ListNode()
                {
                    val = 4,
                    next = new ListNode()
                    {
                        val = 1,
                        next = new ListNode()
                        {
                            val = 9,
                            next = new ListNode()
                            {
                                val = 6,
                                next = new ListNode()
                                {
                                    val = 6,
                                    next = new ListNode()
                                    {
                                        val = 10,
                                        next = new ListNode()
                                        {
                                            val = 6,
                                            next = null
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };

        int[] result = NodesBetweenCriticalPoints(head);

        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
    }

    public static int[] NodesBetweenCriticalPoints(ListNode head)
    {
        // find all index that match local maxima or local minima.
        // calculate distance between
        List<int> matched = new List<int>();

        ListNode current = head;

        ListNode previous = null;

        int index = 0;
        // head = [6,8,4,1,9,6,6,10,6]

        while (true)
        {
            if (previous == null)
            {
                index++;
                previous = current;
                current = current.next;
                continue;
            }

            index++;

            if (current.next == null) break;

            ListNode next = current.next;

            // check if local maxima

            if ((current.val > previous.val && current.val > next.val)
                || (current.val < previous.val && current.val < next.val))
            {
                matched.Add(index);
            }

            previous = current;
            current = current.next;
        }
       
        if (matched.Count < 2 ) return [-1, -1];

        if (matched.Count == 2)
            return [matched[1] - matched[0], matched[1] - matched[0]];

        int min = int.MaxValue;

        int max = matched[matched.Count - 1] - matched[0];

        for (int i = 0; i < matched.Count - 1; i++)
        {
            min = Math.Min(min, matched[i + 1] - matched[i]);
        }

        return [min, max];
    }
}

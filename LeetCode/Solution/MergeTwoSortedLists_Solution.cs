namespace LeetCode.Solution
{
    public class MergeTwoSortedLists_Solution
    {
        public static void Run()
        {
            MergeTwoLists(new ListNode(), new ListNode());
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            List<int> ints = new List<int>();

            while (true)
            {
                if (list1 == null) break;

                ints.Add(list1.val);

                if (list1.next == null)
                {
                    break;
                }

                list1 = list1.next;
            }

            while (true)
            {
                if (list2 == null) break;

                ints.Add(list2.val);

                if (list2.next == null)
                {
                    break;
                }

                list2 = list2.next;
            }

            int[] intArray = ints.ToArray();

            Array.Sort(intArray);

            ListNode node = BuildNode(intArray.ToList());

            return node;
        }

        public ListNode BuildNode(List<int> ints)
        {
            if (ints.Count == 0)
            {
                return null;
            }

            ListNode node = new ListNode();
            node.val = ints[0];

            ints.RemoveAt(0);

            node.next = BuildNode(ints);

            return node;
        }
    }
}

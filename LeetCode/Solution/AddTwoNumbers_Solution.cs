using System.Numerics;
using static LeetCode.Solution.MergeTwoSortedLists_Solution;

namespace LeetCode.Solution
{
    public class AddTwoNumbers_Solution
    {
        public static void Run()
        {
            ListNode l1 = new ListNode(9, null);
            ListNode l2 = new ListNode(1, 
                new ListNode(9, 
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9
                ))))))))));

            ListNode result = AddTwoNumbers(l1, l2);

            while (result != null)
            {
                Console.Write(result.val);
                result = result.next;
            }
            
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string l1String = new string(GetListNodeString(l1).Reverse().ToArray());
            string l2String = new string(GetListNodeString(l2).Reverse().ToArray());

            BigInteger l1Int = BigInteger.Parse(l1String);
            BigInteger L2Int = BigInteger.Parse(l2String);

            string result = (l1Int + L2Int).ToString();

            string reverseResult = new string(result.Reverse().ToArray());

            ListNode node = BuildNode(reverseResult);

            return node;
        }

        public static ListNode BuildNode(string resultString)
        {
            if(resultString.Length > 0)
            {
                string c = resultString.Substring(0, 1);

                resultString = resultString.Remove(0, 1);

                ListNode node = new ListNode(int.Parse(c));

                node.next = BuildNode(resultString);

                return node;
            }

            return null;
        }

        public static string GetListNodeString(ListNode l)
        {
            if(l.next != null)
            {
                return l.val.ToString() + GetListNodeString(l.next);
            }
            else
            {
                return l.val.ToString();
            }
        }
    }
}

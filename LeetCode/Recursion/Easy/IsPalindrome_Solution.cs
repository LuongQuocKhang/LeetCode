namespace LeetCode.Recursion.Easy;

public class IsPalindrome_Solution
{
    /***
   * Tag: Easy
   * Name: 326. Is Palindrome
   * Start Time: 17/01/2025 4:45 PM
   * End Time: 17/01/2025 4:50 PM
   * Time Complexity: O(N)
   * Result: 
       * Runtime: solution 1: Beats 64.78% of users with C# ( 4ms )
       * Memory:  solution 1: Beats 17.48% of users with C# ( 70.44MB )
   ***/

    public static void Run()
    {
        ListNode node = new ListNode(1,
            new ListNode(2,
            new ListNode(21, new ListNode(1))));

        Console.WriteLine(IsPalindrome(node));

    }

    public static bool IsPalindrome(ListNode head)
    {
        List<int> ints = new List<int>();

        while(head != null)
        {
            ints.Add(head.val);

            head = head.next;
        }

        // 1 2 2 1

        int i = 0, j = ints.Count - 1;

        while (i < j)
        {
            if (ints[i] != ints[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
}

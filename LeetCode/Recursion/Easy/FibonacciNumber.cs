namespace LeetCode.Recursion.Easy;

internal class FibonacciNumber
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
        Console.WriteLine(Fib(4));
    }

    public static int Fib(int n)
    {
        if (n <= 1) return n;

        int a = 0, b = 1;

        while (n > 1)
        {
            int sum = a + b;

            a = b;
            b = sum;

            n--;
        }

        return b;
    }
}

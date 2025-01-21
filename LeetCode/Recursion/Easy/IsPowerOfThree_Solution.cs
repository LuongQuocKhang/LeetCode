public class IsPowerOfThree_Solution
{
    /***
    * Tag: Easy
    * Name: 326. Power of Three
    * Start Time: 17/01/2025 1:45 PM
    * End Time: 17/01/2025 10:00 AM
    * Result: 
        * Runtime: solution 1: Beats 100.00% of users with C# ( 1ms )
        * Memory:  solution 1: Beats 9.22% of users with C# ( 34.92MB )
    ***/

    public static void Run()
    {
        System.Console.WriteLine(IsPowerOfThree(1));
    }

    public static bool IsPowerOfThree(int n) {
        if (n <= 0) return false;
        if (n == 1) return true;

        if (n % 3 != 0) return false;
        
        n /= 3;

        return IsPowerOfThree(n);
    }
}
using System.Diagnostics;

namespace LeetCode.Recursion.Easy;

static class TowerOfHanoi
{
    /***
    * Tag: Medium
    * Name: 1190. Reverse Substrings Between Each Pair of Parentheses
    * Start Time: 11/07/2024 9:45 AM
    * End Time: 11/07/2024 10:00 AM
    * Time Complexity: O(2^N)
    * Result: 
        * Runtime: solution 1: Beats 50.00% of users with C# ( 135ms )
        * Memory:  solution 1: Beats 8.33% of users with C# ( 68.94MB )
    ***/

    //    To solve this recurrence relation, we can use the method of repeated substitution: [T(n) = 2T(n - 1) + O(1)]
    //    [T(n - 1) = 2T(n - 2) + O(1)]
    //    [T(n - 2) = 2T(n - 3) + O(1)]
    //    Substituting these back, we get: [T(n) = 2[2T(n - 2) + O(1)] + O(1) ] [T(n) = 2^2T(n - 2) + 2O(1) + O(1)][T(n) = 2^2[2T(n - 3) + O(1)] + 2O(1) + O(1) ] [T(n) = 2^3T(n - 3) + 2^2O(1) + 2O(1) + O(1)]
    //    Continuing this process, we get: [T(n) = 2^kT(n - k) + 2^{k-1}
    //    O(1) + 2^{k-2}O(1) + \ldots + 2O(1) + O(1) ]
    //  When(k = n) : [T(n) = 2^nT(0) + 2^{n-1}O(1) + 2 ^{ n - 2}
    //  O(1) + \ldots + 2O(1) + O(1) ]
    //  Since(T(0)) is a constant, we can simplify this to: [T(n) = O(2 ^ n)]
    //  Therefore, the time complexity of the ToH function is ( O(2^n) 

    public static void Run()
    {
        /**
         *  sourceCol: first column
         *  useCol: second column ( use as a temporary column )
         *  desCol: destination column
         */

        int sourceCol = 1, useCol = 2, desCol = 3, d = 4;
        Console.WriteLine("A -> C");
        ToH(n: 3,
            a: sourceCol,
            b: useCol,
            c: desCol);
        Console.WriteLine("C -> D");
        ToH(n: 3,
            a: desCol,
            b: useCol,
            c: d);
    }

    private static void ToH(int n, int a, int b, int c)
    {
        if (n == 0) return;

#pragma warning disable S2234 // Arguments should be passed in the same order as the method parameters
        ToH(n - 1, a, c, b);
#pragma warning restore S2234 // Arguments should be passed in the same order as the method parameters
        Console.WriteLine($"({a}, {c})");
#pragma warning disable S2234 // Arguments should be passed in the same order as the method parameters
        ToH(n - 1, b, a, c);
#pragma warning restore S2234 // Arguments should be passed in the same order as the method parameters
    }
}

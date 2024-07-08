namespace LeetCode.String.Easy;

public class FindFirstPalindromicStringInTheArray
{
    /***
        * Tag: Easy
        * Name: 2108. Find First Palindromic String in the Array
        * Start Time: 08/07/2024 14:10 PM
        * End Time: 08/07/2024 14:20 PM
        * Result: 
            * Runtime: solution 1: Beats 72.66% of users with C# ( 87ms )
            * Memory:  solution 1: Beats 63.32% of users with C# ( 50.16MB )
    ***/

    public static void Run()
    {
        string[] words = ["abc", "car", "ada", "racecar", "cool"];
        System.Console.WriteLine(FirstPalindrome(words));
    }

    public static string FirstPalindrome(string[] words)
    {
        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                return word;
            }
        }
        return string.Empty;
    }

    public static bool IsPalindrome(string word)
    {
        int left = 0, right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
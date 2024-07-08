using System.Text;

namespace LeetCode.String.Easy;

public class FinalStringSolution
{
    /***
    * Tag: Easy
    * Name: 2810. Faulty Keyboard
    * Start Time: 08/07/2024 17:40 AM
    * End Time: 08/07/2024 17:42 PM
    * Result: 
        * Runtime: solution 1: Beats 37.96% of users with C# ( 72ms )
        * Memory:  solution 1: Beats 90.74% of users with C# ( 50.35MB )
    ***/

    public static void Run()
    {
        Console.WriteLine(FinalString("string"));
    }

    public static string FinalString(string s)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in s)
        {
            if(c == 'i')
            {
                int left = 0;
                int right = sb.Length - 1;
                while(left < right)
                {
                    char temp = sb[left];
                    sb[left] = sb[right];
                    sb[right] = temp;

                    left++;
                    right--;
                }
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

}

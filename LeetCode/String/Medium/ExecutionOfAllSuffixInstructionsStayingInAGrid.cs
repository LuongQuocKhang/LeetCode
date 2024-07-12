namespace LeetCode.String.Medium;
public class ExecutionOfAllSuffixInstructionsStayingInAGrid
{
    /***
    * Tag: Medium
    * Name: 1190. Reverse Substrings Between Each Pair of Parentheses
    * Start Time: 11/07/2024 9:45 AM
    * End Time: 11/07/2024 10:00 AM
    * Result: 
        * Runtime: solution 1: Beats 50.00% of users with C# ( 135ms )
        * Memory:  solution 1: Beats 8.33% of users with C# ( 68.94MB )
    ***/

    public static void Run()
    {
        int n = 3;
        int[] startPos = [0, 1];
        string s = "RRDDLU";

        int[] ints = ExecuteInstructions(n, startPos, s);

        foreach (var item in ints)
        {
            System.Console.Write(item + " ");
        }
    }

    public static int[] ExecuteInstructions(int n, int[] startPos, string s)
    {
        int[] result = new int[s.Length];

        int index = 0;
    
        while (true)
        {
            string temp = s[(index)..(s.Length)];

            if (temp == string.Empty) break;

            int count = 0;
            int row = startPos[0];
            int col = startPos[1];

            foreach (char c in temp)
            {
                if (c == 'R')
                {
                    col++;
                    if (col >= n)
                    {
                        break;
                    }
                    count++;
                }
                else if (c == 'L')
                {
                    col--;
                    if (col < 0)
                    {
                        break;
                    }
                    count++;
                }
                else if (c == 'U')
                {
                    row--;
                    if (row < 0)
                    {
                        break;
                    }
                    count++;
                }
                else if (c == 'D')
                {
                    row++;
                    if (row >= n)
                    {
                        break;
                    }
                    count++;
                }
            }

            result[index] = count;

            index++;
        }

        return result;
    }
}
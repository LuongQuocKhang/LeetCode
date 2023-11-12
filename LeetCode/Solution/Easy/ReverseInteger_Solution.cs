using System.Text;

namespace LeetCode.Solution.Easy;

public class ReverseInteger_Solution
{
    public static void Run()
    {
        Console.WriteLine(Reverse(1234));
    }

    public static int Reverse(int x)
    {
        try
        {
            string numString = Math.Abs(x).ToString();
            StringBuilder result = new StringBuilder();
            for (int i = numString.Length - 1; i >= 0; i--)
            {
                result.Append(numString[i]);
            }
            int iresult = int.Parse(result.ToString());
            return x < 0 ? iresult * -1 : iresult;
        }
        catch
        {
            return 0;
        }
    }
}

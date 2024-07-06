namespace LeetCode.String.Easy;

public class CountItemsMatchingARule
{
    /***
     * Tag: Easy
     * Name: 1773. Count Items Matching a Rule
     * Start Time: 06/07/2024 22:09 PM
     * End Time: 06/07/2024 22:17 PM
     * Result: 
         * Runtime: solution 1: Beats 86.78% of users with C# ( 134ms )
         * Memory:  solution 1: Beats 60.34% of users with C# ( 55.02MB )
     ***/

    public static void Run()
    {
        // name, color, type
        Console.WriteLine(CountMatches([["phone", "blue", "pixel"], ["computer", "silver", "phone"], ["phone", "gold", "iphone"]],
            "type",
            "phone"));
    }

    public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        int count = 0;

        foreach (IList<string> item in items)
        {
            switch (ruleKey)
            {
                case "type":
                    {
                        if (item[0] == ruleValue)
                        {
                            count++;
                        }
                        break;
                    }
                case "color":
                    {
                        if (item[1] == ruleValue)
                        {
                            count++;
                        }
                        break;
                    }
                case "name":
                    {
                        if (item[2] == ruleValue)
                        {
                            count++;
                        }
                        break;
                    }
            }
        }

        return count;
    }
}

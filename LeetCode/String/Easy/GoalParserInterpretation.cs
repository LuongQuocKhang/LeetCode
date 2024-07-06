namespace LeetCode.String.Easy;

public class GoalParserInterpretation
{
    /***
      * Tag: Easy
      * Name: 1678. Goal Parser Interpretation
      * Start Time: 06/07/2024 20:59 PM
      * End Time: 06/07/2024 21:00 PM
      * Result: 
          * Runtime: solution 1: Beats 20.30% of users with C# ( 60ms )
          * Memory:  solution 1: Beats 21.83% of users with C# ( 38.83MB )
      ***/

    public static void Run()
    {
        Console.WriteLine(Interpret("G()(al)"));
    }

    public static string Interpret(string command)
    {
        return command
            .Replace("()", "o")
            .Replace("(al)", "al");
    }
}

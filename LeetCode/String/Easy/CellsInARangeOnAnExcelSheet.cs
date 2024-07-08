namespace LeetCode.String.Easy;

public class CellsInARangeOnAnExcelSheet
{
    /***
    * Tag: Easy
    * Name: 2194. Cells in a Range on an Excel Sheet
    * Start Time: 08/07/2024 11:52 AM
    * End Time: 08/07/2024 12:02 PM
    * Result: 
        * Runtime: solution 1: Beats 43.55% of users with C# ( 115ms )
        * Memory:  solution 1: Beats 9.68% of users with C# ( 57.30MB )
    ***/

    public static void Run()
    {
        IList<string> cells = CellsInRange("A1:F1");
        foreach (var item in cells)
        {
            Console.Write(item + " ");
        }
    }

    public static IList<string> CellsInRange(string s) 
    {
        int endRow = int.Parse(s[4].ToString()); // 2
        int startRow = int.Parse(s[1].ToString());
        int startCol = s[0];
        int endCol = s[3];

        List<string> cells = new List<string>();

        for (int i = startCol; i <= endCol; i++)
        {
            for (int j = startRow; j <= endRow; j++)
            {
                string cell = $"{((char)i).ToString()}{j}";

                cells.Add(cell);
            }
        }

        return cells;
    }
}
namespace LeetCode.Sliding_Window.Easy
{
    public class FindTheKBeautyOfaNumber_Solution
    {
        /***
        * Start Time: 14/11/2023 3:56 PM
        * End Time: 14/11/2023 4:00 PM
        * Result: 
        *   Runtime: solution 1: Beats 71.67% of users with C# ( 20ms )
        *   Memory:  solution 1: Beats 70.00%of users with C# ( 26.76MB )
        */
        public static void Run()
        {
            int num = 430043, k = 2;
            Console.WriteLine(DivisorSubstrings(num, k));
        }

        public static int DivisorSubstrings(int num, int k)
        {
            int count = 0;

            string numString = num.ToString();

            for (int end = 0; end < numString.Length; end++)
            {
                if(end + k - 1 < numString.Length)
                {
                    string subString = numString[end..(end + k)];

                    int k_beauty = int.Parse(subString);

                    if (k_beauty == 0) continue;

                    if (num % k_beauty == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}

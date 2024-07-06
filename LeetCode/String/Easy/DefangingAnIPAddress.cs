using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String.Easy
{
    public class DefangingAnIPAddress
    {
        /***
       * Tag: Easy
       * Name: 13. Roman to Integer
       * Start Time: 06/07/2024 15:35 PM
       * End Time: 06/07/2024 15:35 PM
       * Result: 
           * Runtime: solution 1: Beats 47.32% of users with C# ( 55ms )
           * Memory:  solution 1: Beats 23.34% of users with C# ( 38.59MB )
       ***/

        public static void Run()
        {
            Console.WriteLine(DefangIPaddr("1.1.1.1"));
        }

        public static string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}

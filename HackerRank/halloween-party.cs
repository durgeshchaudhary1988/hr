using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class halloween_party
    {
        public static void maxChocolate()
        {
            int totalTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < totalTestCases; i++)
            {
                Int64 currentTestCase = Convert.ToInt64(Console.ReadLine());
                Int64 horizontal = currentTestCase / 2;
                Console.WriteLine(horizontal * (currentTestCase - horizontal));
            }
        }
    }
}

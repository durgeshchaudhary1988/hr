using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class the_love_letter_mystery
    {
        public static void makePalindrome()
        {
            int totalTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < totalTestCases; i++)
            {
                int j=0;
                int operationCount = 0;
                string currentTestCase = Console.ReadLine();
                int middleLocation = (currentTestCase.Length -1) / 2;
                while (j <= middleLocation)
                {
                    if (currentTestCase[j] != currentTestCase[currentTestCase.Length - (j + 1)])
                        operationCount += Math.Abs((currentTestCase[j] - currentTestCase[currentTestCase.Length - (j + 1)]));
                    j++;
                }
                Console.WriteLine(operationCount);
            }
        }
    }
}

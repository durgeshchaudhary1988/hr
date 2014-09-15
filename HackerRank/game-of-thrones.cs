using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class game_of_thrones
    {
        public static void IsPalindromePossible()
        {
            string testCase = Console.ReadLine();
            int[] repeated = new int[26];
            bool hasOddPassed = false;
            bool isStringLengthOdd = (testCase.Length % 2 == 1);
            foreach (char ch in testCase)
                repeated[ch - 'a']++;
            foreach (int i in repeated)
            {
                if (i % 2 == 1)
                {
                    if (isStringLengthOdd && !hasOddPassed)
                    {
                        hasOddPassed = true;
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}

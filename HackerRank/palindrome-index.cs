using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class palindrome_index
    {
        public static void makePalindrome()
        {
            int totalTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < totalTestCases; i++)
            {
                int j=0;
                bool isPalindrome = true;
                string currentTestCase = Console.ReadLine();
                int middleLocation = (currentTestCase.Length+1)/2;
                while (j <= middleLocation)
                {
                    if (currentTestCase[j] != currentTestCase[currentTestCase.Length - (j + 1)])
                    {
                        isPalindrome = false;
                        break;
                    }
                    j++;
                }
                if (!isPalindrome)
                {
                    isPalindrome = true;
                    int k = j + 1;
                    while (k <= middleLocation)
                    {
                        if (currentTestCase[k] != currentTestCase[currentTestCase.Length - (k)])
                        {
                            isPalindrome = false;
                            break;
                        }
                        k++;
                    }
                    if (isPalindrome)
                        Console.WriteLine(j);
                    else
                        Console.WriteLine(currentTestCase.Length - (j + 1));
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
        }
    }
}

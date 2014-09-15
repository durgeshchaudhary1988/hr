using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class utopian_tree
    {
        public static void getHeight()
        {
            int totalTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < totalTestCases; i++)
            {
                int currentTestCase = Convert.ToInt32(Console.ReadLine());
                int height = 1;
                int j = 0;
                while (j < currentTestCase)
                {
                    if (j % 2 == 1)
                        height++;
                    else
                        height *= 2;
                    j++;
                }
                Console.WriteLine(height);
            }
        }
    }
}

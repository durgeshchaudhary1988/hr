using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class service_lane
    {
        public static void findLargestVehicle()
        {
            string[] testCases = Console.ReadLine().Split(new char[] { ' ' });
            string widths = Console.ReadLine();
            int totalTestCases = Convert.ToInt32(testCases[1]);
            string[] highWayWidthInString = widths.Split(new char[] { ' ' });
            int[] highWayWidth = new int[Convert.ToInt32(testCases[0])];
            for (int i = 0; i < highWayWidth.Length; i++)
                highWayWidth[i] = Convert.ToInt32(highWayWidthInString[i]);
            for (int i = 0; i < totalTestCases; i++)
            {
                bool[] isPresent = new bool[] { false, false, false };
                string[] entryExit = Console.ReadLine().Split(new char[] { ' ' });
                int entry = Convert.ToInt32(entryExit[0]);
                int exit = Convert.ToInt32(entryExit[1]);
                for (int j = entry; j <= exit; j++)
                    isPresent[highWayWidth[j] - 1] = true;
                if (isPresent[0]) Console.WriteLine(1);
                else if (isPresent[1]) Console.WriteLine(2);
                else if (isPresent[2]) Console.WriteLine(3);
            }
        }
    }
}

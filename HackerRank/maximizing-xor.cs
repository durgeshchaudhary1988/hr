using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class maximizing_xor
    {
        public static void findMaxXORCount(int l, int r)
        {
            Int64 maxXOR = 0;
            for (Int64 i = l; i <= r; i++)
                for (Int64 j = i; j <= r; j++)
                {
                    Int64 result = (i ^ j);
                    if (result > maxXOR)
                    {
                        maxXOR = result;
                    }
                }
            Console.WriteLine(maxXOR);
        }
    }
}

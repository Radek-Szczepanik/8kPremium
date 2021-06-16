using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CountJewelsInStonesLinq("aA", "aAAbbbb");
        }

        public static int CountJewelsInStones(string jewels, string stones)
        {
            int count = 0;

            for (int i = 0; i < stones.Length; i++)
            {
                if (jewels.Contains(stones[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountJewelsInStonesLinq(string jewels, string stones)
            => stones.Where(s => jewels.Contains(s)).Count();
    }
}

using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CountJewelsInStones("aaaAb", "zzzAca");
            CountJewelsInStonesLinq("aaaAb", "zzzAca");
        }

        public static int CountJewelsInStones(string jewels, string stones)
        {
            int counter = 0;

            for (int i = 0; i < stones.Length; i++)
            {
                if (jewels.Contains(stones[i]))
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int CountJewelsInStonesLinq(string jewels, string stones)
            => stones.Where(s => jewels.Contains(s)).Count();
    }
}

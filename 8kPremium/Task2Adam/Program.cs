using System;
using System.Linq;

namespace Task2Adam
{
    class Program
    {
        static void Main(string[] args)
        {
            NumJewelsInStones("aaAz", "cA");
            Count("aaAz", "cA");
        }

        public static int NumJewelsInStones(string J, string S)
        {
            char[] Jewels = J.ToCharArray();
            char[] Stones = S.ToCharArray();
            int num = 0;

            //Use a for loop to traverse the array to compare one by one.
            for (int i = 0; i < Jewels.Length; i++)
            {
                for (int j = 0; j < Stones.Length; j++)
                {
                    //3, the number of gems appears plus one
                    if (Jewels[i] == Stones[j])
                    {
                        num++;
                    }
                }
            }
            return num;
        }

        private static int Count(string stones, string jewels)
        {
            var bag = jewels.ToHashSet();
            return stones.Count(bag.Contains);
        }

    }
}

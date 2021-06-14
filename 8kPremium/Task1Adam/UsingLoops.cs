using System;

namespace Task1Adam
{
    public class UsingLoops
    {
        public int BinaryGap(int n)
        {
            string bits = Convert.ToString(n, 2);
            int longest = 0;
            int curCount = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '0')
                {
                    if (curCount > 0) curCount++;
                    else curCount = 1;
                }
                else curCount = 0;
                if (curCount > longest) longest = curCount;
            }

            return longest;
        }
    }
}

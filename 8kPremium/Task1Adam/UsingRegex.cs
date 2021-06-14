using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task1Adam
{
    public class UsingRegex
    {
        public int BinaryGap(int val)
        {

            var rxGap = new Regex("(?<=1)(0+)(?=1)");
            var strGap = Convert.ToString(val, 2);

            var count = rxGap.Matches(strGap)
                             .Cast<Match>()
                             .Select(m => m.Length)
                             .DefaultIfEmpty(0)
                             .Max();

            Console.WriteLine(count);
            return count;
        }
    }
}

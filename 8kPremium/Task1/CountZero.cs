using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task1
{
    public class CountZero 
    {
        public int BinaryGap(int number)
        {
            // create regex pattern
            Regex rg = new Regex("(?<=1)(0+)(?=1)");

            // convert int to binary
            var convertedNumber = Convert.ToString(number, 2);

            var count = rg.Matches(convertedNumber)
                          .Select(x => x.Length)
                          .DefaultIfEmpty(0)
                          .Max();

            Console.WriteLine(count);
            return count;
        }
    }
}

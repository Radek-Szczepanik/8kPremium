using System;
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

            var count = rg.Matches(convertedNumber)     // count is IEnumerable<int>  Matches return all matches
                          .Select(x => x.Length)        // Select return length of count variable
                          .DefaultIfEmpty(0)            // return 0 if collection is empty
                          .Max();                       // change IEnumerable<int> to int

            Console.WriteLine(count);
            return count;
        }
    }
}

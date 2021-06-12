using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task1
{
    public class CountZero 
    {
        int numberOfZero;
        List<string> count = new List<string>();

        public int BinaryGap(int number)
        {
            var convertedNumber = Convert.ToString(number, 2);

            Regex rg = new Regex(@"1(0+)1");

            MatchCollection matches = rg.Matches(convertedNumber);
            for (int i = 0; i < matches.Count; i++)
            {
                count.Add(matches[i].Groups[1].Value);
            }
            foreach (var item in count)
            {
                numberOfZero = item.Length;
            }
            if(numberOfZero > 0)
            {
                Console.WriteLine(numberOfZero);
            }
            else
            {
                Console.WriteLine("0");
            }

            return numberOfZero;
        }
    }
}

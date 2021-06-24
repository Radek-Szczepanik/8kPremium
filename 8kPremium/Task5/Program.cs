using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            IsSumExist(new List<int> { 1, 2, 3, 4 }, 3);
        }

        public static bool IsSumExist(List<int> numbers, int k)
        {
            foreach (var number in numbers)
            {
                

            }
            if (numbers.Take(2).Sum() == k)
                return true;
            return false;
        }
    }
}

using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            IsSumExist(new List<int> { 9, 5, 2, 3, 7, 1, 0 }, 3);
        }

        public static bool IsSumExist(List<int> numbers, int k)
        {
            int tempNumber;
            foreach (var item in numbers)
            {
                tempNumber = item;

                foreach (var num in numbers)
                {
                    if ((tempNumber + num) == k)
                        return true;
                }
            }
            return false;
        }
    }
}

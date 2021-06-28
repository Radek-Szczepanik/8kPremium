using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            IsSumExist(new List<int> { 9, 5, 2, 3, 7, 1, 0 }, 3);

            IsSumExist1(new int[] { 9, 3, 0, 0, 5, 7 }, 20);
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

        // rozwiązanie Adama

        public static bool IsSumExist1(int[] numbers, int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (value - numbers[i] == numbers[j])
                        return true;
                }
            }
            return false;
        }
    }
}

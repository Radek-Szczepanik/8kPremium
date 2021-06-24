using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            TitleToNumber("a");
        }
        
        public static int TitleToNumber(string columnTitle)
        {
            if (string.IsNullOrEmpty(columnTitle)) 
                throw new ArgumentNullException("Wartość kolumny nie może być pusta");

            columnTitle = columnTitle.ToUpper();

            int sum = 0;

            for (int i = 0; i < columnTitle.Length; i++)
            {
                sum *= 26;
                sum += (columnTitle[i] - 'A' + 1);
            }

            return sum;
        }
    }
}

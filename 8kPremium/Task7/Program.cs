using System;
using System.Collections.Generic;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanToInt();
        }

        public static int RomanToInt()
        {
            var numbers = new Dictionary<string, int>
            {
                { "I", 1 }, { "II", 2 }, { "III", 3 }, { "IV", 4 }, { "V", 5 }, { "VI", 6 }, { "VII", 7 },
                { "VIII", 8 }, { "IX", 9 }, { "X", 10 }, { "XX", 20}, { "XXX", 30}, { "XL", 40 }, { "L", 50},
                { "LX", 60 }, { "LXX", 70 }, { "LXXX", 80 }, { "XC", 90 }, { "C", 100 }, { "CC", 200 },
                { "CCC", 300}, { "CD", 400 }, { "D", 500 }, { "DC", 600 }, { "DCC", 700 }, { "DCCC", 800 },
                { "CM", 900 }, { "M", 1000}, { "MD", 1500 }, { "MM", 2000 }, { "MMM", 3000 }
            };
            Console.WriteLine("Podaj cyfrę rzymską: ");
            string userInput = Console.ReadLine().ToUpper();
            int value = 0;
            if (numbers.TryGetValue(userInput, out value))
            {
                Console.WriteLine($"{value}");
            }
            else
            {
                Console.WriteLine("nie znaleziono");
            }
            return value;
        }
    }
}

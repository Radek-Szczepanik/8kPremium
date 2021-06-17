using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = "abc<def>ghi";

            Regex rg = new Regex("[a]");

            ShowCollection(rg.Matches(patern));
        }

        static void ShowCollection(MatchCollection match)
        {
            for (int i = 0; i < match.Count; i++)
            {
                Console.Write(match[i]);
            }
            Console.WriteLine();
        }
    }
}

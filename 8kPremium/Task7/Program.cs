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

        public static void RomanToInt()
        {
            var numbers = new Dictionary<string, int>();
            numbers.Add("I", 1);
            numbers.Add("II", 2);
            numbers.Add("III", 3);

            Console.WriteLine(numbers["II"]);
            

            
            
        }
    }
}

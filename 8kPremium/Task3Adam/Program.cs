using System;
using System.Linq;

namespace Task3Adam
{
    class Program
    {
        static void Main(string[] args)
        {
            // IsPangram("The quick brown fox jumps over the lazy dog");
            IsPangramLinq("The quick brown fox jumps over the lazyy dogg");
        }

        public static bool IsPangram(string sentence)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;

            foreach (char c in alpha)
            {
                foreach (char l in sentence.ToLower())
                {
                    if (c == l)
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count == 26)
                return true;
            return false;
        }

        public static bool IsPangramLinq(string sentence)
        {
            return sentence.ToLower().Where(ch => char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
        }
    }
}

using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPangram("The quick brown fox jumps over the lay dog");

        }

        public static bool IsPangram(string sentence)
        {
            string result = sentence.ToLower().Replace(" ", "");
            
            for (var letter = 'a'; letter <= 'z'; letter++)
            {
                if (result.Contains(letter))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

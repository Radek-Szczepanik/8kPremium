using System;
using System.Collections.Generic;
using System.Linq;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            IsValid("([)]");
        }

        public static bool IsValid(string s)
        {
            Stack<char> brackets = new Stack<char>();
            Dictionary<char, char> bracketsPairs = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            try
            {
                foreach (var item in s)
                {
                    if (bracketsPairs.Keys.Contains(item))
                        brackets.Push(item);
                    else if (bracketsPairs.Values.Contains(item))
                    {
                        if (item == bracketsPairs[brackets.First()])
                            brackets.Pop();
                        else
                            return false;
                    }
                    else
                        continue;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return brackets.Count() == 0 ? true : false;
        }
    }
}

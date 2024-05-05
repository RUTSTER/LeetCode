using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class ValidPalindrome_125
    {
        public bool IsPalindrome(string s)
        {
            var lastI = s.Length - 1;

            if (lastI == 0)
            {
                return true;
            }

            var forwardI = 0;
            var backwardI = 0;
            while (forwardI + backwardI <= lastI)
            {
                if (!char.IsLetterOrDigit(s[forwardI]))
                {
                    forwardI++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[lastI - backwardI]))
                {
                    backwardI++;
                    continue;
                }

                if (char.ToLower(s[forwardI]) != char.ToLower(s[lastI - backwardI]))
                {
                    return false;
                }

                forwardI++;
                backwardI++;
            }

            return true;
        }


        public void Test()
        {
            var s = "A man, a plan, a canal: Panama";

            var k = IsPalindrome(s);

            Console.WriteLine();
        }
    }
}

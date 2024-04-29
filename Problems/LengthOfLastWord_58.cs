using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class LengthOfLastWord_58
    {
        public int LengthOfLastWord(string s)
        {
            var lastChar = s.Length - 1;
            var length = 0;
            for (int i = lastChar; i >= 0; i--)
            {
                if (i == lastChar && s[lastChar] == ' ')
                {
                    while (s[i] == ' ')
                    {
                        i--;
                    }
                }

                if (s[i] == ' ')
                {
                    return length;
                }

                length++;
            }

            return 0;
        }

        public void Test()
        {
            var str = "   fly me   to   the moon  ";

            var k = LengthOfLastWord(str);

            Console.WriteLine();
        }
    }
}

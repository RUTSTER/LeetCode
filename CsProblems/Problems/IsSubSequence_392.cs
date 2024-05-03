using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class IsSubSequence_392
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Equals(""))
            {
                return true;
            }

            if (t.Equals(""))
            {
                return false;
            }

            var subIndex = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] != s[subIndex])
                {
                    continue;
                }

                subIndex++;

                if (subIndex == s.Length)
                {
                    return true;
                }
            }

            return false;
        }

        public void Test()
        {
            var subsequence = "abcw";
            var str = "ahbgdc";

            var k = IsSubsequence(subsequence, str);

            Console.WriteLine();
        }
    }
}

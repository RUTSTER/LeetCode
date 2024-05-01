using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class FirstSubstringInString_28
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] != needle[0])
                {
                    continue;
                }

                for (int j = 0; j <  needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }

                    if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public void Test()
        {
            var haystack = "happybutsad";
            var needle = "sad";

            var k = StrStr(haystack, needle);

            Console.WriteLine();
        }
    }
}

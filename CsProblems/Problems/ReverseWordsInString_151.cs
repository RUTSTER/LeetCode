using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class ReverseWordsInString_151
    {
        public string ReverseWords(string s)
        {
            var reversed = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();
            return string.Join(' ', reversed);
        }

        public void Test()
        {
            var triangle = "  the  sky is blue";

            var k = ReverseWords(triangle);

            Console.WriteLine();
        }
    }
}

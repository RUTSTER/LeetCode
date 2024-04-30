using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class LongestCommonPrefix_14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var prefix = new StringBuilder();

            for (int i = 0; i < strs[0].Length; i++)
            {
                var currentChar = strs[0][i];
                foreach (var str in strs)
                {
                    if (str.Length <= i || currentChar != str[i])
                    {
                        return prefix.ToString();
                    }
                }

                prefix.Append(currentChar);
            }

            return prefix.ToString();
        }

        public void Test()
        {
            string[] strs = ["flower", "flow", "flight"];

            var k = LongestCommonPrefix(strs);

            Console.WriteLine();
        }
    }
}

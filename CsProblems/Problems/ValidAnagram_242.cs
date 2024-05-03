using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class ValidAnagram_242
    {
        public bool IsAnagram(string s, string t)
        {
            var sCharsEntries = GetCharsEntries(s);
            var tCharsEntries = GetCharsEntries(t);

            if (sCharsEntries.Count != tCharsEntries.Count)
            {
                return false;
            }

            foreach (var ch in sCharsEntries.Keys) 
            {
                if (!tCharsEntries.ContainsKey(ch) || sCharsEntries[ch] != tCharsEntries[ch])
                {
                    return false;
                }
            }
            return true;
        }

        private Dictionary<char, int> GetCharsEntries(string str)
        {
            var charsCount = new Dictionary<char, int>();

            foreach (var ch in str)
            {
                if (!charsCount.ContainsKey(ch))
                {
                    charsCount[ch] = 0;
                }

                charsCount[ch]++;
            }

            return charsCount;
        }

        public void Test()
        {
            var s = "car";
            var t = "rae";

            var k = IsAnagram(s, t);

            Console.WriteLine();
        }
    }
}

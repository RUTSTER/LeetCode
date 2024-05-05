using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class RansomNote_383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var ransomNoteCharsEntries = GetCharsEntries(ransomNote);
            var magazineCharsEntries = GetCharsEntries(magazine);

            foreach (var ransomNoteChar in ransomNoteCharsEntries.Keys)
            {
                if (!magazineCharsEntries.ContainsKey(ransomNoteChar))
                {
                    return false;
                }

                if (magazineCharsEntries[ransomNoteChar] < ransomNoteCharsEntries[ransomNoteChar])
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
            var ransomNote = "aa";
            var magazine = "aab";

            var k = CanConstruct(ransomNote, magazine);

            Console.WriteLine();
        }
    }
}

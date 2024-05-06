using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class WordPattern_290
    {
    public bool WordPattern(string pattern, string s)
    {
        if (pattern.Length < 2)
        {
            return true;
        }

        var words = s.Split(' ');

        if (pattern.Length != words.Length)
        {
            return false;
        }

        var mapCharsToWords = new Dictionary<char, string>();
        var mapWordsToChars = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; i++)
        {
            var isKnownChar = mapCharsToWords.ContainsKey(pattern[i]);
            var isKnownWord = mapWordsToChars.ContainsKey(words[i]);

            if (isKnownChar ^ isKnownWord)
            {
                return false;
            }

            if (!isKnownChar)
            {
                mapCharsToWords.Add(pattern[i], words[i]);
                mapWordsToChars.Add(words[i], pattern[i]);
                continue;
            }

            if (words[i] != mapCharsToWords[pattern[i]])
            {
                return false;
            }
        }

        return true;
    }


        public void Test()
        {
            var patternT = "abba";
            var strT = "dog cat cat dog";
            var t = WordPattern(patternT, strT);

            var patternF = "abba";
            var strF = "dog dog dog dog";
            var f = WordPattern(patternF, strF);

            Console.WriteLine();
        }
    }
}

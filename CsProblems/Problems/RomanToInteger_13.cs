using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class RomanToInteger_13
    {
        public int RomanToInt(string s)
        {
            var mapCharToInt = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            // last symbol is always about addition, so add it instantly
            var result = mapCharToInt[s[^1]];
            for (int i = 0; i < s.Length - 1; i++)
            {
                var currentNumber = mapCharToInt[s[i]];
                var nextNumber = mapCharToInt[s[i + 1]];
                var isSubtraction = currentNumber < nextNumber;
                result = isSubtraction ? result - currentNumber : result + currentNumber;
            }

            return result;
        }

        public void Test()
        {
            var roman = "MCMXCIV";

            var res = RomanToInt(roman);

            Console.WriteLine();
        }
    }
}

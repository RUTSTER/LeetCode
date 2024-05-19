using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class LetterCombinationsOfPhoneNumber_17
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (digits == "")
            {
                return new List<string>();
            }

            var mapDigitsToLetters = new Dictionary<char, string>()
            {
                { '2', "abc" },
                { '3', "def" },
                { '4', "ghi" },
                { '5', "jkl" },
                { '6', "mno" },
                { '7', "pqrs" },
                { '8', "tuv" },
                { '9', "wxyz" }
            };

            var combinationsCount = 1;
            foreach (var digit in digits)
            {
                combinationsCount *= mapDigitsToLetters[digit].Length;
            }

            var combinations = new List<char[]>(combinationsCount);

            for (var i = 0; i < combinationsCount; i++)
            {
                combinations.Add(new char[digits.Length]);
            }


            for (int comboI = 0; comboI < combinationsCount; comboI++)
            {
                var combination = combinations[comboI];
                var countOfElementsWithSameValueInOrder = combinationsCount;
                for (int elem = 0; elem < combination.Length; elem++)
                {
                    var letters = mapDigitsToLetters[digits[elem]];
                    countOfElementsWithSameValueInOrder /= letters.Length;
                    var letterI = (comboI / countOfElementsWithSameValueInOrder) % letters.Length;
                    combination[elem] = letters[letterI];
                }
            }

            var combinationsStrings = new List<string>(combinationsCount);
            for (int i = 0; i < combinationsCount; i++)
            {
                combinationsStrings.Add(new string(combinations[i]));
            }

            return combinationsStrings;
        }

        public void Test()
        {
            var digits = "23";

            var res = LetterCombinations(digits);

            foreach (var combo in res)
            {
                Console.WriteLine(combo);
            }

            Console.WriteLine();
        }
    }
}

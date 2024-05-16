using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class ValidParentheses_20
    {
        public bool IsValid(string s)
        {

            if (s.Length < 2)
            {
                return false;
            }

            var mapCloseToOpen = new Dictionary<char, char>(3)
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

            var bracketsStack = new Stack<char>(s.Length / 2);
            for (int i = 0; i < s.Length; i++)
            {
                var br = s[i];

                // if open
                if (br == '(' || br == '{' || br == '[')
                {
                    bracketsStack.Push(br);
                    continue;
                }

                // if close
                if (bracketsStack.Count == 0 || mapCloseToOpen[br] != bracketsStack.Pop())
                {
                    return false;
                }
            }

            if (bracketsStack.Count != 0)
            {
                return false;
            }

            return true;
        }


        public void Test()
        {
            var parentheses = "({[([])[{}]{()}]})";

            var res = IsValid(parentheses);

            Console.WriteLine();
        }
    }
}

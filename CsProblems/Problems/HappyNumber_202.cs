using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class HappyNumber_202
    {
        // Overengineering
        public bool IsHappy(int n)
        {
            var cache = new HashSet<int>() { n };

            while (n != 1)
            {
                var digits = SplitToDigits(n);
                n = 0;

                for (var i = 0; i < digits.Length; i++)
                {
                    n += (int)Math.Pow(digits[i], 2);
                }
                
                if (cache.Contains(n))
                {
                    return false;
                }

                cache.Add(n);
            }

            return true;
        }

        private int[] SplitToDigits(int n)
        {
            var digits = new int[GetDigitsCount(n)];


            for (int i = digits.Length - 1; i > 0; i--)
            {
                var divider = (int)Math.Pow(10, i);
                digits[i] = n / divider;
                n %= divider;
            }

            digits[0] = n;

            return digits;
        }

        private int GetDigitsCount(int n)
        {
            var digitsCount = 1;
            while (Math.Pow(10, digitsCount) <= n)
            {
                digitsCount++;
            }

            return digitsCount;
        }

        public void Test()
        {
            var n = 19;

            var k = IsHappy(n);

            Console.WriteLine();
        }
    }
}

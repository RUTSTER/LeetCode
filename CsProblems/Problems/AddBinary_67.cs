using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class AddBinary_67
    {
        public string AddBinary(string a, string b)
        {
            var carry = 0;
            var length = a.Length >= b.Length ? a.Length : b.Length;
            var sum = new StringBuilder();

            for (int i = 1; i <= length; i++)
            {
                var currentA = 0;
                if (a.Length >= i && a[^i] == '1')
                {
                    currentA = 1;
                }

                var currentB = 0;
                if (b.Length >= i && b[^i] == '1')
                {
                    currentB = 1;
                }

                var tmp = currentA + currentB + carry;

                carry = tmp / 2;
                sum.Insert(0, tmp % 2);
            }

            if (carry != 0)
            {
                sum.Insert(0, carry);
            }

            return sum.ToString();
        }


        public void Test()
        {
            var a = "1010";
            var b = "1011";

            var k = AddBinary(a, b);

            Console.WriteLine();
        }
    }
}

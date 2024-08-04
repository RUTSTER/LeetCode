using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class PalindromeNumber_9
    {
        public bool IsPalindrome(int x)
        {            
            var strX = x.ToString();
            if (strX.Length < 2)
            {
                return true;
            }

            for (int i = 0; i < strX.Length / 2; i++)
            {
                if (strX[i] != strX[^(i+1)])
                {
                    return false;
                }
            }

            return true;
        }


        public void Test()
        {
            var x = 1392931;


            var res = IsPalindrome(x);

            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class MaximumAchievableNumber_2769
    {
        public int TheMaximumAchievableX(int num, int t)
        {
            return num + (t * 2);
        }


        public void Test()
        {
            var num = 3;
            var t = 2;

            var res = TheMaximumAchievableX(num, t);

            Console.WriteLine();
        }
    }
}

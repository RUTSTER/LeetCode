using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class SummaryRanges_228
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            if (nums.Length == 0)
            {
                return Array.Empty<string>();
            }

            var ranges = new List<string>();

            var currentRangeStart = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                long gap = (long)nums[i] - nums[i - 1];
                if (gap > 1)
                {
                    ranges.Add(rangeToString(currentRangeStart, nums[i - 1]));
                    currentRangeStart = nums[i];
                }
            }

            ranges.Add(rangeToString(currentRangeStart, nums[^1]));

            return ranges;
        }

        private string rangeToString(int a, int b)
        {
            if (a == b)
            {
                return a.ToString();
            }

            return $"{a}->{b}";
        }

        public void Test()
        {
            int[] nums = [0, 2, 3, 4, 6, 8, 9, 10, 11, 12, 15];
            int[] numsBig = [-2147483648, -2147483647, 2147483647];

            var res = SummaryRanges(numsBig);

            Console.WriteLine();
        }
    }
}

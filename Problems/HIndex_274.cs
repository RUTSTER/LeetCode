using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class HIndex_274
    {
        public int HIndex(int[] citations)
        {
            Array.Sort(citations, (a, b) => b.CompareTo(a));
            for (int i = 0; i < citations.Length; i++)
            {
                if (i >= citations[i])
                {
                    return i;
                }
            }
            return citations.Length;
        }

        public void Test()
        {
            int[] nums = [1, 3, 1];

            var k = HIndex(nums);

            Console.WriteLine();
        }
    }
}

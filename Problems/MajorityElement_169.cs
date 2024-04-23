using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class MajorityElement_169
    {
        public int MajorityElement(int[] nums)
        {
            var entryCountByElement = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (!entryCountByElement.ContainsKey(num))
                {
                    entryCountByElement.Add(num, 0);
                }

                entryCountByElement[num]++;
            }

            return entryCountByElement.MaxBy(keyValuePair => keyValuePair.Value).Key;
        }

        public void Test()
        {
            int[] num = [2, 2, 1, 1, 1, 2, 2];

            var k = MajorityElement(num);

            Console.WriteLine();
        }
    }
}

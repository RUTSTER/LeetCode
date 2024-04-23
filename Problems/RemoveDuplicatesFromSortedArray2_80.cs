using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class RemoveDuplicatesFromSortedArray2_80
    {
        public int RemoveDuplicates(int[] nums)
        {
            var correctLastIndex = 1;
            int previousNum = nums[0];
            int previousNumCount = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                nums[correctLastIndex] = nums[i];

                if (nums[i] != previousNum)
                {
                    correctLastIndex++;
                    previousNum = nums[i];
                    previousNumCount = 1;
                    continue;
                }

                if (++previousNumCount <= 2)
                {
                    correctLastIndex++;
                }
            }

            return correctLastIndex;
        }

        public void Test()
        {
            int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];

            var k = RemoveDuplicates(nums);

            Console.WriteLine();
        }
    }
}

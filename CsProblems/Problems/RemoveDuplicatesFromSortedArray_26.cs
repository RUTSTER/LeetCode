using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class RemoveDuplicatesFromSortedArray_26
    {
        public int RemoveDuplicates(int[] nums)
        {
            var removed = 0;
            int previousNum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i - removed] = nums[i];

                if (nums[i] == previousNum)
                {
                    removed++;
                }

                previousNum = nums[i];
            }

            return nums.Length - removed;
        }

        public void Test()
        {
            int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];

            var k = RemoveDuplicates(nums);

            Console.WriteLine();
        }
    }
}

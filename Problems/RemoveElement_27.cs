using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class RemoveElement_27
    {
        public int RemoveElement(int[] nums, int val)
        {
            var valCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i - valCount] = nums[i];

                if (nums[i] == val)
                {
                    valCount++;
                }
            }

            return nums.Length - valCount;
        }

        public void Test()
        {
            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
            int val = 2;

            var k = RemoveElement(nums, val);

            Console.WriteLine();
        }
    }
}

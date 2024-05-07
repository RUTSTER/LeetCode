using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class TwoSum_1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var requiredValueTillTargetToIndex = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (requiredValueTillTargetToIndex.ContainsKey(nums[i]))
                {
                    return [requiredValueTillTargetToIndex[nums[i]], i];
                }

                requiredValueTillTargetToIndex[target - nums[i]] = i;
            }

            return [0, 1];
        }


        public void Test()
        {
            int[] nums = [2, 7, 11, 15];
            var target = 17;

            var k = TwoSum(nums, target);

            Console.WriteLine();
        }
    }
}

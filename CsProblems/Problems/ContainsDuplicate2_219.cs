using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class ContainsDuplicate2_219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var lastEntryIdByValue = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (!lastEntryIdByValue.ContainsKey(num))
                {
                    lastEntryIdByValue[num] = i;
                    continue;
                }

                if (i - lastEntryIdByValue[num] <= k)
                {
                    return true;
                }

                lastEntryIdByValue[num] = i;
            }

            return false;
        }

        // just for fun
        public bool ContainsNearbyDuplicate2(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]) && i - map[nums[i]] <= k)
                {
                    return true;
                }

                map[nums[i]] = i;
            }

            return false;
        }

        public void Test()
        {
            int[] nums = [1, 2, 3, 1, 2, 3];
            var k = 2;

            var res = ContainsNearbyDuplicate(nums, k);

            Console.WriteLine();
        }
    }
}

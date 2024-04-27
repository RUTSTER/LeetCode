using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class ProductOfArrayExceptSelf_238
    {
    public int[] ProductExceptSelf(int[] nums)
    {
        var answer = new int[nums.Length];

        var moveRight = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            answer[i] = moveRight;
            moveRight *= nums[i];
        }

        var moveLeft = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= moveLeft;
            moveLeft *= nums[i];
        }

        return answer;
    }

        public void Test() 
        {
            int[] nums = [1, 2, 3, 4];

            var res = ProductExceptSelf(nums);

            Console.WriteLine();
        }
    }
}

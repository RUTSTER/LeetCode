using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class RotateArray_189
    {
        public void Rotate(int[] nums, int k)
        {
            var shift = k % nums.Length;
        
            if (shift == 0)
            {
                return;
            }
        
            CascadeReplace(ref nums, 0, shift);
        
        
            var gcd = GetGreatestCommonDivisor(nums.Length, shift);
            var lcm = GetLeastCommonMultiple(nums.Length, shift, gcd);

            if (lcm % gcd == 0)
            {
                for (int i = 1; i < gcd; i++)
                {
                    CascadeReplace(ref nums, i, shift);
                }
            }

            GC.Collect();
        }

        private void CascadeReplace(ref int[] nums, int startIndex, int shift)
        {
            var targetIndex = startIndex;
            var length = nums.Length;
            var storage = nums[targetIndex];
        
            while (true)
            {
                var sourceIndex = (length + targetIndex - shift) % length;
                if (sourceIndex == startIndex)
                {
                    nums[targetIndex] = storage;
                    return;
                }
        
                nums[targetIndex] = nums[sourceIndex];
                targetIndex = sourceIndex;
            }
        }

        private int GetGreatestCommonDivisor(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        private int GetLeastCommonMultiple(int a, int b, int gcd)
        {
            return (a * b) / gcd;
        }

        public void Test()
        {
            int[] num = [0, 1, 2, 3, 4, 5];

            num = Enumerable.Range(0, 6).ToArray();

            var k = 4;
            Rotate(num, k);

            Console.WriteLine();
        }
    }
}

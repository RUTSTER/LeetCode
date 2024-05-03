using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class MergeSortedArray_88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var lastM = m - 1;
            var lastN = n - 1;

            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                if ( lastM < 0)
                {
                    nums1[i] = nums2[lastN--];
                    continue;
                }

                if (lastN < 0)
                {
                    break;
                }

                nums1[i] = nums1[lastM] >= nums2[lastN] ? nums1[lastM--] : nums2[lastN--];               
            }
        }

        public void Test()
        {
            int[] num1 = [1, 2, 3, 0, 0, 0];
            int m = 3; 
            int[] num2 = [2, 5, 6];
            int n = 3;

            Merge(num1, m, num2, n);

            Console.WriteLine();
        }
    }
}

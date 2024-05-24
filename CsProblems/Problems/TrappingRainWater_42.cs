using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class TrappingRainWater_42
    {
    public int Trap(int[] height)
    {
        var highestFromLeft = 0;
        var hightDifFromLeft = new int[height.Length];
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] > highestFromLeft)
            {
                highestFromLeft = height[i];
            }

            hightDifFromLeft[i] = highestFromLeft - height[i];
        }

        var highestFromRight = 0;
        var hightDifFromRight = new int[height.Length];
        for (int i = height.Length - 1; i >= 0; i--)
        {
            if (height[i] > highestFromRight)
            {
                highestFromRight = height[i];
            }

            hightDifFromRight[i] = highestFromRight - height[i];
        }

        var trappedWater = 0;
        for (int i = 0; i < height.Length; i++)
        {
            trappedWater += hightDifFromLeft[i] < hightDifFromRight[i] ? hightDifFromLeft[i] : hightDifFromRight[i];
        }

        return trappedWater;
    }

        public void Test()
        {
            int[] nums = [0, 1, 0, 10, 5, 0, 5, 15, 10, 1, 5, 3];

            var res = Trap(nums);

            Console.WriteLine();
        }
    }
}

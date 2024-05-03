using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class Triangle_120
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle.Count == 1)
            {
                return triangle[0][0];
            }

            for (int row = triangle.Count - 2; row >= 0; row--)
            {
                for (int element = 0; element < triangle[row].Count; element++)
                {
                    var leftChild = triangle[row + 1][element];
                    var rightChild = triangle[row + 1][element + 1];

                    triangle[row][element] += leftChild <= rightChild ? leftChild : rightChild;
                }
            }

            return triangle[0][0];
        }

        private string ToStr(IList<IList<int>> triangle)
        {
            var sb = new StringBuilder();
            foreach (var row in triangle)
            {
                foreach (var element in row)
                {
                    sb.Append($"[{element}] ");
                }

                sb.Append("\n");
            }

            return sb.ToString();
        }

        public void Test()
        {
            int[][] triangle = [[2], [3, 4], [6, 5, 7], [4, 1, 8, 3]];

            var k = MinimumTotal(triangle);

            Console.WriteLine();
        }
    }
}

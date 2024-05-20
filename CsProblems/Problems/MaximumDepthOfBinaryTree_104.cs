using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class MaximumDepthOfBinaryTree_104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root is null)
            {
                return 0;
            }

            var leftMax = MaxDepth(root.left);
            var rightMax = MaxDepth(root.right);

            var maxSubtree = leftMax > rightMax ? leftMax : rightMax;

            return maxSubtree + 1;
        }

        public void Test()
        {
            var tree = new TreeNode(3, 
                        new TreeNode(9, null, null), 
                        new TreeNode(20, 
                            new TreeNode(15, null, null), 
                            new TreeNode(7, null, null)
                            )
                        );

            var res = MaxDepth(tree);

            Console.WriteLine();
        }



        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}

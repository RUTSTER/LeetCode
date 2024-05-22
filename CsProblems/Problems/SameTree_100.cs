using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProblems.Problems
{
    internal class SameTree_100
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p is null ^ q is null)
            {
                return false;
            }

            if (p is null)
            {
                return true;
            }

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right) && p.val == q.val;
        }


        public void Test()
        {
            var p = new TreeNode(3,
                        new TreeNode(9, null, null),
                        new TreeNode(20,
                            new TreeNode(15, null, null),
                            new TreeNode(7, null, null)
                            )
                        );

            var q = new TreeNode(3,
                        new TreeNode(9, null, null),
                        new TreeNode(20,
                            new TreeNode(15, null, null),
                            new TreeNode(7, null, null)
                            )
                        );

            var res = IsSameTree(p, q);

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

namespace CsProblems.Problems;

internal class SymmetricTree_101
{
    public bool IsSymmetric(TreeNode root)
    {
        return IsSymmetric(root.left, root.right);
    }

    public bool IsSymmetric(TreeNode? l, TreeNode? r)
    {
        if (l is null || r is null)
        {
            return l is null && r is null;
        }

        return l.val == r.val
               && IsSymmetric(l.left, r.right)
               && IsSymmetric(l.right, r.left);
    }


    public void Test()
    {
        var tree = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(3,
                    new TreeNode(9),
                    new TreeNode(6)
                ),
                new TreeNode(4,
                    new TreeNode(5),
                    null
                )
            ),
            new TreeNode(2,
                new TreeNode(4,
                    null,
                    new TreeNode(5)
                ),
                new TreeNode(3,
                    new TreeNode(6),
                    new TreeNode(9)
                )
            )
        );

        var res = IsSymmetric(tree);

        Console.WriteLine(res);
    }

    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;

        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
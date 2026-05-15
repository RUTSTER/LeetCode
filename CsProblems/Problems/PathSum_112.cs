namespace CsProblems.Problems;

internal class PathSum_112
{
    public bool HasPathSum(TreeNode? root, int targetSum)
    {
        if (root is null)
            return false;

        return Dfs(root, targetSum);
    }

    private bool Dfs(TreeNode node, int remainingSum)
    {
        remainingSum -= node.val;
        
        if (node.left is null && node.right is null)
            return remainingSum == 0;

        return node.left is not null && Dfs(node.left, remainingSum)
               || node.right is not null && Dfs(node.right, remainingSum);
    }

    public void Test()
    {
        var tree = new TreeNode(5,
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
            new TreeNode(4,
                new TreeNode(11,
                    null,
                    new TreeNode(2)
                ),
                new TreeNode(3,
                    new TreeNode(6),
                    new TreeNode(9)
                )
            )
        );

        var res = HasPathSum(tree, 22);

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
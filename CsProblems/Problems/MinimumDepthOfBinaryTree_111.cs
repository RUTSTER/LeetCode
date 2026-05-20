namespace CsProblems.Problems;

internal class MinimumDepthOfBinaryTree_111
{
    public int MinDepth(TreeNode? root)
    {
        if (root is null)
            return 0;
        
        var depth = 0;
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            depth++;
            var levelSize = queue.Count;
            
            while (levelSize-- > 0)
            {
                var node = queue.Dequeue();

                if (node.left is null && node.right is null)
                    return depth;

                if (node.left is not null)
                    queue.Enqueue(node.left);
                
                if (node.right is not null)
                    queue.Enqueue(node.right);
            }
        }

        return 0;
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

        var res = MinDepth(tree);

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
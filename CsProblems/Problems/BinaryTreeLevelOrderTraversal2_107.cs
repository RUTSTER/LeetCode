using System.Text;

namespace CsProblems.Problems;

internal class BinaryTreeLevelOrderTraversal2_107
{
    public IList<IList<int>> LevelOrderBottom(TreeNode? root)
    {
        var levels = new List<IList<int>>();
        if (root == null)
        {
            return levels;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var levelSize = queue.Count;
            var levelValues = new List<int>();
            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                
                levelValues.Add(node.val);
                
                if (node.left is not null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right is not null)
                {
                    queue.Enqueue(node.right);
                }
            }
            
            levels.Add(levelValues);
        }

        levels.Reverse();
        return levels;
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

        var res = LevelOrderBottom(tree);

        Console.WriteLine(Print(res));
    }
    
    private string Print(IList<IList<int>> levels)
    {
        var str = new StringBuilder();
        str.Append("[ ");
        foreach (var l in levels)
        {
            str.Append("[ ");
            foreach (var n in l)
            {
                str.Append($"{n}, ");
            }
            str.Length -= 2;
            str.Append(" ], ");
        }
        str.Length -= 2;
        str.Append(" ]");

        return str.ToString();
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
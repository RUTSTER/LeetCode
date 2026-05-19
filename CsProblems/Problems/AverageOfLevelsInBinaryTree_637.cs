using System.Text;

namespace CsProblems.Problems;

internal class AverageOfLevelsInBinaryTree_637
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        var result = new List<double>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var levelSize = queue.Count;
            long levelSum = 0;

            for (var i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                levelSum += node.val;

                if (node.left is not null)
                {
                    queue.Enqueue(node.left);
                }
                
                if (node.right is not null)
                {
                    queue.Enqueue(node.right);
                }
            }
            
            result.Add((double)levelSum / levelSize);
        }
        
        return result;
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

        var res = AverageOfLevels(tree);

        Console.WriteLine(Print(res));
    }

    private string Print(IList<double> avarages)
    {
        var str = new StringBuilder();
        str.Append("[ ");
        foreach (var v in avarages)
        {
            str.Append($"{v}, ");
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
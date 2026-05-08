namespace CsProblems.Problems;

internal class ConvertSortedArrayToBinarySearchTree_108
{
    public TreeNode SortedArrayToBST(ReadOnlySpan<int> nums)
    {
        var midIndex = nums.Length / 2;
        var node = new TreeNode(val: nums[midIndex]);

        if (midIndex > 0)
        {
            node.left = SortedArrayToBST(nums[..midIndex]);
        }
        
        if (midIndex + 1 < nums.Length)
        {
            node.right = SortedArrayToBST(nums[(midIndex + 1)..]);
        }
        
        return node;
    }


    public void Test()
    {
        var nums = new[] { -10, -6, -4, -3, 0, 1, 3, 5, 9 };

        var res = SortedArrayToBST(nums);

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
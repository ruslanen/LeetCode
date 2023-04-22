namespace LeetCode._102_Binary_Tree_Level_Order_Traversal;

public class Program
{
    public static void Main()
    {
        var case1 = new TreeNode()
        {
            val = 3,
            left = new TreeNode(9),
            right = new TreeNode()
            {
                val = 20,
                left = new TreeNode(15),
                right = new TreeNode(7)
            }
        };
        var case2 = new TreeNode()
        {
            val = 1,
            left = new TreeNode(2)
            {
                left = new TreeNode(4),
                right = new TreeNode(5),
            },
            right = new TreeNode(3)
            {
                left = new TreeNode(6),
                right = new TreeNode(7)
            }
        };
        var solution = new Solution_2();
        var result1 = solution.LevelOrder(case1);
        Console.WriteLine(result1);
        
        var result2 = solution.LevelOrder(case2);
        Console.WriteLine(result2);
    }
}

// Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
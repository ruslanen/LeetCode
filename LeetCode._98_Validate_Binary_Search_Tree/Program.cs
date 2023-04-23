using LeetCode._98_Validate_Binary_Search_Tree;

public class Program
{
    // Не решено
    public static void Main()
    {
        var case1 = new TreeNode()
        {
            val = 2,
            left = new TreeNode(1),
            right = new TreeNode(3)
        };
        var case2 = new TreeNode()
        {
            val = 5,
            left = new TreeNode(1),
            right = new TreeNode(4)
            {
                left = new TreeNode(3),
                right = new TreeNode(6)
            }
        };
        var case3 = new TreeNode()
        {
            val = 1,
            right = new TreeNode(1),
        };
        var case4 = new TreeNode()
        {
            val = 2,
            left = new TreeNode(2),
            right = new TreeNode(2),
        };
        var case5 = new TreeNode()
        {
            val = 32,
            left = new TreeNode()
            {
                val = 26,
                left = new TreeNode()
                {
                    val = 19,
                    right = new TreeNode(25)
                    {
                        left = new TreeNode(18),
                        right = new TreeNode(24)
                    }
                }
            },
            right = new TreeNode()
            {
                val = 47,
                right = new TreeNode(56)
            },
        };
        var case6 = new TreeNode()
        {
            val = 3,
            left = new TreeNode()
            {
                val = 1,
                left = new TreeNode(0),
                right = new TreeNode(2),
            },
            right = new TreeNode()
            {
                val = 5,
                left = new TreeNode(4),
                right = new TreeNode(6),
            },
        };
        var case7 = new TreeNode(5)
        {
            left = new TreeNode(4),
            right = new TreeNode(6)
            {
                left = new TreeNode(3),
                right = new TreeNode(7)
            }
        };
        var case8 = new TreeNode(98)
        {
            left = new TreeNode(-57)
            {
                right = new TreeNode(58)
                {
                    left = new TreeNode(31)
                }
            }
        };
        var case9 = new TreeNode(Int32.MinValue)
        {
            right = new TreeNode(Int32.MaxValue)
        };
        var solution = new Solution2();
        var result1 = solution.IsValidBST(case1); // true
        var result2 = solution.IsValidBST(case2); // false
        var result3 = solution.IsValidBST(case3); // false
        var result4 = solution.IsValidBST(case4); // false
        var result5 = solution.IsValidBST(case5); // false
        var result6 = solution.IsValidBST(case6); // true
        var result7 = solution.IsValidBST(case7); // false
        var result8 = solution.IsValidBST(case8); // true
        var result9 = solution.IsValidBST(case9); // true
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
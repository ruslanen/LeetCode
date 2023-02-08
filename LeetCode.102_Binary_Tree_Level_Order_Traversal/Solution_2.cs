namespace LeetCode._102_Binary_Tree_Level_Order_Traversal;

// ReSharper disable once InconsistentNaming
public class Solution_2
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var levelOrderResult = Enumerable.Range(1, GetMaxDepth(root, 1))
            .Select(x => (IList<int>) new List<int>())
            .ToList();
        levelOrderResult[0] = new List<int>() {root.val};
        LevelOrderInternal(root, 1, levelOrderResult);
        return levelOrderResult;
    }

    public void LevelOrderInternal(TreeNode root, int level, List<IList<int>> values)
    {
        if (root == null)
        {
            return;
        }

        if (root.left != null)
        {
            values[level].Add(root.left.val);
            LevelOrderInternal(root.left, level + 1, values);
        }

        if (root.right != null)
        {
            values[level].Add(root.right.val);
            LevelOrderInternal(root.right, level + 1, values);
        }
    }

    private int GetMaxDepth(TreeNode root, int level)
    {
        if (root == null)
        {
            return level;
        }

        var leftDepth = 0;
        if (root.left != null)
        {
            leftDepth = GetMaxDepth(root.left, level + 1);
        }

        var rightDepth = 0;
        if (root.right != null)
        {
            rightDepth = GetMaxDepth(root.right, level + 1);
        }

        return Math.Max(level, Math.Max(leftDepth, rightDepth));
    }
}
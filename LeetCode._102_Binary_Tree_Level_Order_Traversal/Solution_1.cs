namespace LeetCode._102_Binary_Tree_Level_Order_Traversal;

// ReSharper disable once InconsistentNaming
public class Solution_1
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var levelOrderResult = new List<IList<int>>();
        if (root == null)
        {
            return levelOrderResult;
        }
        var result = new Dictionary<int, List<TreeNode>>();
        result.Add(0, new List<TreeNode>() { root });
        LevelOrderInternal(root, 1, result);

        foreach (var entry in result)
        {
            levelOrderResult.Add(entry.Value.Select(x=>x.val).ToList());
        }

        return levelOrderResult;
    }

    public void LevelOrderInternal(TreeNode root, int level, Dictionary<int, List<TreeNode>> result)
    {
        if (root == null)
        {
            return;
        }

        if (root.left != null)
        {
            TryAdd(level, root.left, result);
            LevelOrderInternal(root.left, level + 1, result);
        }

        if (root.right != null)
        {
            TryAdd(level, root.right, result);
            LevelOrderInternal(root.right, level + 1, result);
        }
    }

    private void TryAdd(int key, TreeNode valueEntry, Dictionary<int, List<TreeNode>> result)
    {
        if (result.TryGetValue(key, out var value))
        {
            value.Add(valueEntry);
        }
        else
        {
            result[key] = new List<TreeNode>() {valueEntry};
        }
    }
}
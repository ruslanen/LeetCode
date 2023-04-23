namespace LeetCode._98_Validate_Binary_Search_Tree;

public class Solution2
{
    /// <summary>
    /// Бинарное дерево поиска - это двоичное дерево, в котором:
    /// - оба поддерева (левое и правое) - это двоичные дерева поиска
    /// - у всех узлов левого поддерева узла X значения меньше либо равны ключу узла X
    /// - у всех узлов правого поддерева узла X значения больше либо равны ключу узла X
    ///
    ///            3
    ///        /       \
    ///       1         5
    ///     /   \     /   \
    ///    0     2   4     6
    /// </summary>
    public bool IsValidBST(TreeNode root) => IsValid(root);

    private bool IsValid(TreeNode? node, int? leftBound = null, int? rightBound = null)
    {
        if (node == null)
        {
            return true;
        }

        if (node.val <= leftBound)
        {
            return false;
        }

        if (node.val >= rightBound)
        {
            return false;
        }

        var leftResult = IsValid(node.left, leftBound, node.val);
        var rightResult = IsValid(node.right, node.val, rightBound);

        return leftResult && rightResult;
    }
}
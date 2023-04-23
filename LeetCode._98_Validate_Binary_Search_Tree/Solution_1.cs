namespace LeetCode._98_Validate_Binary_Search_Tree;

public class Solution1
{
    // Wrong result
    public bool IsValidBST(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        TreeNode nextLeft = root.left ?? null;
        TreeNode nextRight = root.right ?? null;
        TreeNode next = null;
        TreeNode prev = null;
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            
            var left = current.left;
            if (left != null)
            {
                stack.Push(left);
            }
            
            var right = current.right;
            if (right != null)
            {
                stack.Push(right);
            }

            if (current.left != null)
            {
                if (current.val <= current.left.val)
                {
                    return false;
                }
                
                if (!CheckLeft(current.left, root))
                {
                    return false;
                }

                nextLeft = current.left;
                next = current.left;
            }

            if (current.right != null)
            {
                if (current.val >= current.right.val)
                {
                    return false;
                }
                
                if (!CheckRight(current.right, root))
                {
                    return false;
                }
                
                nextRight = current.right;
                next = current.right;
            }

            prev = current;
        }

        return true;
    }

    private bool CheckRight(TreeNode node, TreeNode prev)
    {
        if (//prev.val >= node.val ||
            node.left != null && node.val <= node.left.val ||
            node.right != null && node.val >= node.right.val)
        {
            return false;
        }

        return true;
    }
    
    private bool CheckLeft(TreeNode node, TreeNode prev)
    {
        if (//prev.val <= node.val ||
            node.left != null && node.val <= node.left.val ||
            node.right != null && node.val >= node.right.val)
        {
            return false;
        }

        return true;
    }
}
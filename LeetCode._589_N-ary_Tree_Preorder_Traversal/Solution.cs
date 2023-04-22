namespace LeetCode._589_N_ary_Tree_Preorder_Traversal;

public class Solution
{
    public IList<int> Preorder(Node root)
    {
        var result = new List<int>();
        if (root == null)
        {
            return result;
        }

        var stack = new Stack<Node>();
        stack.Push(root);
        while (stack.Count != 0)
        {
            var current = stack.Pop();
            result.Add(current.val);

            if (current.children != null)
            {
                for (int i = current.children.Count - 1; i >= 0; i--)
                {
                    stack.Push(current.children[i]);
                }
            }
        }

        return result;
    }
}

// Definition for a Node.
public class Node
{
    public int val;
    public IList<Node> children;

    public Node()
    {
    }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, IList<Node> _children)
    {
        val = _val;
        children = _children;
    }
}
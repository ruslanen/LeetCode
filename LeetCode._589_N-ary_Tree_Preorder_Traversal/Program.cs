namespace LeetCode._589_N_ary_Tree_Preorder_Traversal;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.Preorder(
            new Node(
                1,
                new List<Node>()
                {
                    new Node(3, new List<Node>()
                    {
                        new Node(5),
                        new Node(6),
                    }),
                    new Node(2),
                    new Node(4),
                }));
    }
}
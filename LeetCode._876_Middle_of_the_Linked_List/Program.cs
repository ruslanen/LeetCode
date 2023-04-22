namespace LeetCode._876_Middle_of_the_Linked_List;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 =
            solution.MiddleNode(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));
    }
}
namespace LeetCode._206_Reverse_Linked_List;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 =
            solution.ReverseList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));
    }
}
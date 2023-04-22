namespace LeetCode._142_Linked_List_Cycle_II;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 =
            solution.DetectCycle(new ListNode(3)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(0)
                    {
                        next = new ListNode(-4)
                    }
                }
            });
    }
}
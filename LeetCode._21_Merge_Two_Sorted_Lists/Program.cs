using LeetCode._21_Merge_Two_Sorted_Lists;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var result1 = solution.MergeTwoLists(list1, list2);
    }
}
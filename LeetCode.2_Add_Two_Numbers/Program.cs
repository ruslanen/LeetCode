using LeetCode._2_Add_Two_Numbers;

public class Program
{
    public static void Main()
    {
        var list1left = new ListNode(1, new ListNode(0, new ListNode(1, new ListNode(9))));
        var list1right = new ListNode(5, new ListNode(7, new ListNode(8)));

        var list2left = new ListNode(2, new ListNode(4, new ListNode(3)));
        var list2right = new ListNode(5, new ListNode(6, new ListNode(4)));

        var list3left = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        var list3right = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        
        var result2 = new Solution().AddTwoNumbers(list2left, list2right);
        var result3 = new Solution().AddTwoNumbers(list3left, list3right);
    }
}


// Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
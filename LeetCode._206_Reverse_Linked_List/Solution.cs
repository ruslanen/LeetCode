namespace LeetCode._206_Reverse_Linked_List;

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var reversed = ReverseList(head.next);
        var tmp = head.next;
        head.next = null;
        tmp.next = head;


        return reversed;
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
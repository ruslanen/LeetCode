namespace LeetCode._142_Linked_List_Cycle_II;

public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return null;
        }

        var slowIterator = head;
        var fastIterator = head;
        while (fastIterator != null || fastIterator?.next != null)
        {
            slowIterator = slowIterator?.next;
            fastIterator = fastIterator.next?.next;
            if (slowIterator == fastIterator)
            {
                break;
            }
        }

        if (fastIterator == null || fastIterator.next == null)
        {
            return null;
        }

        slowIterator = head;
        while (slowIterator != fastIterator)
        {
            slowIterator = slowIterator.next;
            fastIterator = fastIterator.next;
        }

        return fastIterator;
    }
}

// Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}
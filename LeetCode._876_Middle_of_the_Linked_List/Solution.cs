namespace LeetCode._876_Middle_of_the_Linked_List;

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode middleNode = null;
        ListNode currentNode = head;
        var countOfNodes = 0;
        while (currentNode != null)
        {
            countOfNodes++;
            currentNode = currentNode.next;
        }

        var nodeFromSelect = (countOfNodes / 2) + 1;
        var i = 0;
        currentNode = head;
        while (currentNode != null)
        {
            i++;
            if (i == nodeFromSelect)
            {
                middleNode = currentNode;
                currentNode = null;
            }
            else
            {
                currentNode = currentNode.next;
            }
        }

        return middleNode;
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
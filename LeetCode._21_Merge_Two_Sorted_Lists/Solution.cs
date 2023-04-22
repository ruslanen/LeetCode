namespace LeetCode._21_Merge_Two_Sorted_Lists;

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        #region Edge cases

        if (list1 == null)
        {
            return list2;
        }

        if (list1 == null)
        {
            return list2;
        }

        #endregion

        ListNode result = null;
        ListNode currentNode = null;
        // Повторяем цикл до тех пор, пока не закончим перебирать оба списка
        while (list1 != null || list2 != null)
        {
            ListNode next;

            // Если перебор первого списка закончен, то выбираем следующим элемент второго списка
            // Полагаемся на то, что списки отсортированы
            if (list1 == null)
            {
                next = list2;
                list2 = list2.next;
            }
            // Если перебор второго списка закончен, то выбираем следующим элемент из первого списка
            else if (list2 == null)
            {
                next = list1;
                list1 = list1.next;
            }
            // Выбираем тот элемент, что меньше, он будет следующим
            else if (list1.val > list2.val)
            {
                next = list2;
                list2 = list2.next;
            }
            else
            {
                next = list1;
                list1 = list1.next;
            }

            // Если currentNode == null, то значит, что это задание первого элемента
            if (currentNode != null)
            {
                currentNode.next = next;
            }

            currentNode = next;

            if (result == null)
            {
                result = currentNode;
            }
        }

        return result;
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
namespace LeetCode._2_Add_Two_Numbers;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return SumListNode(l1, l2);
    }

    private ListNode SumListNode(ListNode left, ListNode right)
    {
        var valueQueue = new Queue<(int left, int right)>();
        // Для начала пройдем по всем узлам связных списков и добавим нулевые значения в отсутствующих разрядах в начале
        // К примеру, для списков:
        // 9 9 9 9 9 9 9
        // 9 9 9 9
        // получим:
        // 9 9 9 9 9 9 9
        // 0 0 0 9 9 9 9
        while (true)
        {
            var leftValue = left?.val ?? 0;
            var rightValue = right?.val ?? 0;
            
            valueQueue.Enqueue((leftValue, rightValue));
            Console.WriteLine($"{leftValue} and {rightValue}");

            if (left?.next == null && right?.next == null)
                break;

            left = left?.next ?? null;
            right = right?.next ?? null;
        }

        var root = new ListNode();
        var current = root;
        var leftToAdd = 0;
        // Просуммируем каждые отдельные разряды с сохранением остатка от сложения
        while (valueQueue.Count != 0)
        {
            var row = valueQueue.Dequeue();
            var rowSum = row.left + row.right;
            if (rowSum > 9)
            {
                var secondValue = rowSum % 10;
                current.next = new ListNode(secondValue + leftToAdd);
                current = current.next;
                leftToAdd = rowSum / 10;
            }
            else
            {
                rowSum += leftToAdd;
                if (rowSum > 9)
                {
                    var secondValue = rowSum % 10;
                    current.next = new ListNode(secondValue);
                    current = current.next;
                    leftToAdd = rowSum / 10;
                }
                else
                {
                    current.next = new ListNode(rowSum);
                    current = current.next;
                    leftToAdd = 0;
                }
            }
        }

        if (leftToAdd != 0)
        {
            current.next = new ListNode(leftToAdd);
        }
        
        return root.next;
    }
}

// 1019
// 5780
//
// 9  1  0  1
// 8  7  5  0
// 17 8  6  1

// 9 9 9 9 9 9 9
// 0 0 0 9 9 9 9
//
// 8 9 9 9 0 0 1
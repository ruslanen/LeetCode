﻿namespace LeetCode._287_Find_the_Duplicate_Number;

public class Solution
{
    // O(n)
    // Алгоритм Флойда (изначально решающий проблему поиска цикла в связном списке)
    public int FindDuplicate(int[] nums)
    {
        // Начинаем с двух указателей, указывающих на первый элемент массива
        int slow = 0;
        int fast = 0;

        // Пока значения slow и fast не станут равными, slow продвигается на одну позицию,
        // а fast - на две или более позиции вперед (а зависимости от nums[fast]).
        // Мы можем полагаться на nums[nums[fast]] благодаря условию из задачи: 1 <= nums[i] <= n
        // Это позволяет нам двигаться по элементам массива и проверять, не находимся ли мы в цикле.
        // Когда slow и fast станут равными, это означает, что мы нашли цикл в массиве.
        do
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        } 
        while (slow != fast);

        // В этот момент мы устанавливаем новый указатель (slow2) на начало массива и двигаем его вместе со slow,
        // но на этот раз мы будем перемещаться только на одну позицию за шаг.
        // Когда slow и slow2 станут равными, это означает, что они встретились в точке,
        // где происходит цикл, то есть мы нашли повторяющийся элемент в массиве.
        int slow2 = 0;
        while (slow != slow2)
        {
            slow = nums[slow];
            slow2 = nums[slow2];
        }

        return slow;
    }
}
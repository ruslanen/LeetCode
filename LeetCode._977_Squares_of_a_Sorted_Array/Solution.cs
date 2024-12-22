namespace LeetCode._977_Squares_of_a_Sorted_Array;

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        var sortedSquares = new int[nums.Length];
        var leftIndex = 0;
        var rightIndex = nums.Length - 1;
        var iterator = nums.Length - 1;
        while (leftIndex <= rightIndex)
        {
            int value;
            if (nums[leftIndex] * nums[leftIndex] >= nums[rightIndex] * nums[rightIndex])
            {
                value = nums[leftIndex] * nums[leftIndex];
                leftIndex++;
            }
            else
            {
                value = nums[rightIndex] * nums[rightIndex];
                rightIndex--;
            }

            sortedSquares[iterator--] = value;
        }

        return sortedSquares;
    }
}
// Найти первый положительный элемент или 0
// создать новый пустой массив
// читать исходный массив с 0 или первого положительного элемента и отрицательного (два читателя)
// вставлять элемент в новый массив в случае 
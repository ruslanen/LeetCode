public class Program
{
    public static void Main()
    {
        var nums = new int[] {-1, 0, 3, 5, 9, 12};
        var target = 2;
        var solution = new Solution();
        var result = solution.Search(nums, target);
        Console.WriteLine(result);
    }
}

public class Solution
{
    public int Search(int[] nums, int target)
    {
        var result = SearchInternal(nums, target, 0, nums.Length);
        return result;
    }

    /// <summary>
    /// Решение без подсказок
    /// O(logn)
    /// </summary>
    private int SearchInternal(int[] nums, int target, int startIndex, int endIndex)
    {
        var middleIndex = (endIndex + startIndex) / 2;
        var middleValue = nums[middleIndex];
        if (middleValue == target)
        {
            return middleIndex;
        }

        var startFrom = startIndex;
        var endTo = endIndex;
        if (middleValue > target)
        {
            endTo = middleIndex;
        }
        else
        {
            startFrom = middleIndex;
        }

        if (startFrom == startIndex && endTo == endIndex)
            return -1;

        return SearchInternal(nums, target, startFrom, endTo);
    }

    /// <summary>
    /// Рекурсивный алгоритм поиска числа в отсортированном массиве.
    /// Поиск будет продолжаться делением массива на части до тех пор, пока не найдется искомое число
    /// или индекс начала будет больше, чем индекс конца для поиска.
    /// O(logn)
    /// </summary>
    private int RecursiveBinarySearch(int[] nums, int target, int start, int end)
    {
        if (start > end)
        {
            return -1;
        }

        // Находим опорный элемент (берем индекс из середины массива)
        var mid = (start + end) / 2;
        if (nums[mid] == target)
        {
            // Если число по этому индексу равно числу, которое мы ищем, то возвращаем его
            return mid;
        }
        else if (nums[mid] < target)
        {
            // Если искомое число больше опорного элемента, то это означает, что нужно искать во второй половине массива (справа).
            return RecursiveBinarySearch(nums, target, mid + 1, end);
        }
        else
        {
            // Если искомое число больше опорного элемента, то это означает, что нужно искать в первой половине массива (слева).
            return RecursiveBinarySearch(nums, target, start, mid - 1);
        }
    }
}
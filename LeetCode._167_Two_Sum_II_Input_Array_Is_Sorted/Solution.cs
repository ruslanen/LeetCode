namespace LeetCode._167_Two_Sum_II_Input_Array_Is_Sorted;

public class Solution
{
    // OK
    // O(n^2)
    public int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            var numberToFind = target - numbers[i];
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numberToFind == numbers[j])
                {
                    return new[] {i + 1, j + 1};
                }
            }
        }

        throw new Exception("Unreachable code");
    }

    // O(nlog n)
    // Лучший способ - бинарный поиск
    public int[] TwoSumV3(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            // Берем следующий индекс (заранее знаем, что нельзя использовать один и тот же элемент)
            var start = i + 1;
            // Берем индекс последнего элемента
            var end = numbers.Length - 1;
            // Вычисляем значение, которое требуется найти в случае,
            // если одно и двух будет равно текущему numbers[i]
            var sum = target - numbers[i];
            // Так как массив отсортирован заранее, то можно выполнить бинарный поиск
            while (start <= end)
            {
                // Находим число посередине
                var mid = start + (end - start) / 2;
                if (numbers[mid] == sum)
                {
                    return new[] {i + 1, mid + 1};
                }

                if (numbers[mid] > sum)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
        }

        throw new Exception("Unreachable code");
    }

    // O(n^2)
    // Time Limit Exceeded
    // Способ глупого квадратичного перебора
    public int[] TwoSumV1(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            var firstNumber = numbers[i];

            for (int j = 0; j < i; j++)
            {
                if (firstNumber + numbers[j] == target && i != j)
                {
                    return new[] {i + 1, j + 1};
                }
            }

            for (int j = i; j < numbers.Length; j++)
            {
                if (firstNumber + numbers[j] == target && i != j)
                {
                    return new[] {i + 1, j + 1};
                }
            }
        }

        throw new Exception("Unreachable code");
    }
}
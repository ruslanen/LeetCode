namespace LeetCode._347_Top_K_Frequent_Elements;

public class Solution
{
    // O(n log n)
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dictionary = new Dictionary<int, int>();
        // Заполнение словаря - O(n)
        for (int i = 0; i < nums.Length; i++)
        {
            if (dictionary.TryGetValue(nums[i], out var value))
            {
                dictionary[nums[i]] = ++value;
            }
            else
            {
                dictionary[nums[i]] = 1;
            }
        }

        // OrderByDescending использует QuickSort с O(n log n)
        // Take выбирает заданное количество элементов, что занимает O(k)
        // ToArray создает новый массив, что занимает O(k)
        return dictionary.OrderByDescending(x => x.Value)
            .Select(x => x.Key)
            .Take(k)
            .ToArray();
    }
}
namespace LeetCode._1493_Longest_Subarray_of_1s_After_Deleting_One_Element;

public class Solution
{
    // public int LongestSubarray(int[] nums)
    // {
    //     if (!nums.Any())
    //     {
    //         // Если нет чисел, то сразу вернем 0
    //         return 0;
    //     }
    //     
    //     var zeroIndices = new List<int>();
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         if (nums[i] == 0)
    //         {
    //             zeroIndices.Add(i);
    //         }
    //     }
    //
    //     if (!zeroIndices.Any())
    //     {
    //         // Если нет ни одного нуля, то можно вернуть весь размер массива минус 1
    //         return nums.Length - 1;
    //     }
    //
    //     if (zeroIndices.Count == nums.Length)
    //     {
    //         // Если все нули, то сразу можно вернуть 0
    //         return 0;
    //     }
    //
    //     var max = 0;
    //     for (int i = 0; i < zeroIndices.Count; i++)
    //     {
    //         var zeroIndex = zeroIndices[i];
    //         var backwardCount = 0;
    //         for (int j = zeroIndex - 1; j >= 0; j--)
    //         {
    //             if (nums[j] == 0)
    //                 break;
    //                 
    //             backwardCount++;
    //         }
    //
    //         var forwardCount = 0;
    //         for (int j = zeroIndex + 1; j < nums.Length; j++)
    //         {
    //             if (nums[j] == 0)
    //                 break;
    //                 
    //             forwardCount++;
    //         }
    //
    //         max = Math.Max(max, backwardCount + forwardCount);
    //     }
    //
    //     return max;
    // }
    
    /// <summary>
    /// Улучшенный алгоритм
    /// </summary>
    public int LongestSubarray(int[] nums)
    {
        int prevOnes = 0, currOnes = 0, max = 0;
        var hasZero = false;

        foreach (int num in nums)
        {
            if (num == 1)
            {
                currOnes++;
            }
            else
            {
                hasZero = true;
                max = Math.Max(max, prevOnes + currOnes);
                prevOnes = currOnes;
                currOnes = 0;
            }
        }

        // Последняя проверка, если массив заканчивается на единицах
        max = Math.Max(max, prevOnes + currOnes);

        // Если вообще не было "0", возвращаем длину массива минус 1
        return hasZero ? max : nums.Length - 1;
    }
}
namespace LeetCode._27_Remove_Element;

public class Solution
{
    // Решение, в котором имеет значение сохранение целостности массива
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
            return 0;
        
        var result = 0;
        var lastIndex = nums.Length - 1;
    
        for (int i = 0; i <= lastIndex; i++)
        {
            if (nums[i] != val)
            {
                result++;
            }
        }
        
        for (int i = 0; i <= lastIndex; i++)
        {
            for (int j = lastIndex; j >= 0; j--)
            {
                if (j > i && nums[i] == val)
                {
                    if (nums[j] != val)
                    {
                        // swap
                        nums[i] = nums[j];
                        nums[j] = val;
                        lastIndex = j;
                    }
                }
            }
        }
    
        return result;
    }
    
    // Правильное решение (It does not matter what you leave beyond the returned k (hence they are underscores).
    // public int RemoveElement(int[] nums, int val)
    // {
    //     int j = 0;
    //     
    //     for (int i = 0; i < nums.Length; i++) {
    //         if (nums[i] != val) {
    //             nums[j] = nums[i];
    //             j++;
    //         }
    //     }
    //     
    //     return j;
    // }
}
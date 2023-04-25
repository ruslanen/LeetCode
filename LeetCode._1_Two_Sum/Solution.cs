namespace LeetCode._1_Two_Sum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target) {
        var dictionary = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            dictionary[target - nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (dictionary.TryGetValue(nums[i],out var value) && value != i)
            {
                return new[] {value, i};
            }
        }
        
        return null;
    }
}
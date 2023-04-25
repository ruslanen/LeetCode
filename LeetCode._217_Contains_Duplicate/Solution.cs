namespace LeetCode._217_Contains_Duplicate;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hashset = new HashSet<int>();
        var containsDuplicate = false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (hashset.Contains(nums[i]))
            {
                containsDuplicate = true;
                break;
            }

            hashset.Add(nums[i]);
        }

        return containsDuplicate;
    }
}
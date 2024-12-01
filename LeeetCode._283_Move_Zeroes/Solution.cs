namespace LeetCode._283_Move_Zeroes;

public class Solution
{
    // public void MoveZeroes(int[] nums)
    // {
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         for (int j = i + 1; j < nums.Length; j++)
    //         {
    //             if (nums[i] == 0)
    //             {
    //                 nums[i] = nums[j];
    //                 nums[j] = 0;
    //             }
    //         }
    //     }
    // }

    public void MoveZeroes(int[] nums)
    {
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] != 0)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left++;
            }
        }
    }
}
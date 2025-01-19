namespace LeetCode._334_Increasing_Triplet_Subsequence;

public class Solution
{
    /// <summary>
    /// Алгоритм на основе двух барьеров
    /// </summary>
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
            return false;

        var first = Int32.MaxValue;
        var second = Int32.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < first)
            {
                first = nums[i];
            }
            else if (nums[i] > first && nums[i] < second)
            {
                second = nums[i];
            }
            else if (nums[i] > second)
            {
                return true;
            }
        }

        return false;
    }
    
    /*
     * ░░░░░░░░░░░░░░░░░░░░░░░▄▄▄▄▄▄░░░░░░░░░░
       ░░░░░░░░░░░░░░░░█▀█▄▄▀▀░░░░░░▀█▄░░░░░░░
       ░░░░░░░░░░░█▀▀▀▀░░░░░░░░░░░░░░░░▀▄▄▄▄░░
       ░░░░░░░░░▄▄▀░░░▄█░░░░░░░░░░░░░░░░▄▄██▄░
       ░░░░░░░░░█░░▄█▀░░▀▀▀▀▀▄▄░░░░░░░▄▄█░▀█░░
       ░░░░░░░░░█░▄▀░░░░░░░░░░░▀▀▀▀▄▄███░░░▀▄░
       ░░░░░░░░░▀▄█▄███▄▄░░░▄▄▄▄░░░░▄▀░░░░░░█░
       ░░░░░░░░░░█▄█▀██▀░░░░█▀▄▄▀░░█░░░░░░░█▀░
       ░░░░░░░░░██░██▀░░░░░▄█▄███░░█░░░░░░░█░░
       ░░░░░░░▄▄█▀█▄░░▄▄▄▄░░█░░░░▄▀░░░░░░░█░░░
       ░░░░░▄▀░░███▄░░▀▀░▀░░░░░▄█▄░░░░░░░█▀░░░
       ░░░▄▀░░░▄█░█▄▄▄▄▄▄▄░░░░░█▀███░░░░░█░░░░
       ░░▄▀░░░░░██████▀▀▀█░░░░░░██░█▄▄▄▄▄█░░░░
       ░█▀░░░░░░██░▄██▀▀██░█░░░▄▀██▀░░░░▀▀▀▄░░
       ▀▀░░░░░░░█▀██░░▄███░█░░░█▀░░░░░░░░░░░█▄
       ░░░░░░░░░░▄█▀▀▀██▀░░░░▄▀░░░░░░░░░░░░░▀▀
       ░░░░░░░░░░▀▄░░░░░░░░▄▀░░░░░░░░░░░░░░░░░
       ░░░░░░░░░░░░█▄▀▀▀▄▀▀░░░░░░░░░░░░░░░░░░░
     */
    // public bool IncreasingTriplet(int[] nums)
    // {
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         for (int j = i + 1; j < nums.Length; j++)
    //         {
    //             for (int k = j + 1; k < nums.Length; k++)
    //             {
    //                 if (nums[i] < nums[j] && nums[j] < nums[k])
    //                 {
    //                     Console.WriteLine($"{nums[i]}<{nums[j]}<{nums[k]}");
    //                     return true;
    //                 }
    //             }
    //         }
    //     }
    //
    //     return false;
    // }
}
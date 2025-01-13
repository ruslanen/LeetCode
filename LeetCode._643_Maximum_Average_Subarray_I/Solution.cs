namespace LeetCode._643_Maximum_Average_Subarray_I;

public class Solution
{
    // public double FindMaxAverage(int[] nums, int k)
    // {
    //     double maxAvg = nums.Min();
    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         if (i + k > nums.Length)
    //             break;
    //         
    //         var sum = 0;
    //         for (int j = i; j < i + k; j++)
    //         {
    //             sum += nums[j];
    //         }
    //
    //         maxAvg = Math.Max(maxAvg, sum / (double)k);
    //     }
    //
    //     return maxAvg;
    // }
    
    public double FindMaxAverage(int[] nums, int k)
    {
        double windowSum = nums[..k].Sum();
        double maxAvg = windowSum / k;
        for (int i = 0; i < nums.Length - k; i++)
        {
            windowSum = windowSum - nums[i] + nums[i + k];
            maxAvg = Math.Max(maxAvg, windowSum / k);

        }
    
        return maxAvg;
    }
}
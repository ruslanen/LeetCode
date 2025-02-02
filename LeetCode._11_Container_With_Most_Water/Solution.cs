namespace LeetCode._11_Container_With_Most_Water;

public class Solution
{
    public int MaxArea(int[] height)
    {
        var maxArea = 0;
        var left = 0;
        var right = height.Length - 1;

        while (left < right)
        {
            var minHeight = Math.Min(height[left], height[right]);
            var width = right - left;
            maxArea = Math.Max(maxArea, minHeight * width);
            if (height[left] > height[right])
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return maxArea;
    }
}
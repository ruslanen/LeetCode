namespace LeetCode._1493_Longest_Subarray_of_1s_After_Deleting_One_Element;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.LongestSubarray(new int[] { 1, 1, 0, 1 });
        var result2 = solution.LongestSubarray(new int[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 });
        var result3 = solution.LongestSubarray(new int[] { 1, 1, 1 });
        var result4 = solution.LongestSubarray(new int[] { 0, 0, 0 });
        var result5 = solution.LongestSubarray(new int[] { 0, 0 });
        var result6 = solution.LongestSubarray(new int[] { 1, 0 });
        var result7 = solution.LongestSubarray(new int[] { });
        var result8 = solution.LongestSubarray(new int[] { 0 });
        var result9 = solution.LongestSubarray(new int[] { 1 });
        var result10 = solution.LongestSubarray(new int[] { 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 1 });
        var result11 = solution.LongestSubarray(new int[] { 1, 1, 0, 0, 1, 1, 1, 0, 1 });
    }
}
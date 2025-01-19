namespace LeetCode._334_Increasing_Triplet_Subsequence;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.IncreasingTriplet(new[] { 1, 2, 3, 4, 5 });
        var result2 = solution.IncreasingTriplet(new[] { 5, 4, 3, 2, 1 });
        var result3 = solution.IncreasingTriplet(new[] { 2, 1, 5, 0, 4, 6 });
        var result4 = solution.IncreasingTriplet(new[] { 0, -1, -2, -3, 1, 4, -1 });
        var result5 = solution.IncreasingTriplet(new[] { 0 });
        var result6 = solution.IncreasingTriplet(new[] { -3, -2, -1 });
        var result7 = solution.IncreasingTriplet(new[] { 20, 100, 10, 12, 5, 13 });
        var result8 = solution.IncreasingTriplet(new[] { 20, 100, 10, 120, 5, 13, 6, 18 });
        var result9 = solution.IncreasingTriplet(new[] { 1, 5, 0, 4, 1, 3 });
    }
}
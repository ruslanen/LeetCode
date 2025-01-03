namespace LeetCode._605_Can_Place_Flowers;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.CanPlaceFlowers(new[] { 1, 0, 0, 0, 1 }, 1);
        var result2 = solution.CanPlaceFlowers(new[] { 1, 0, 0, 0, 1 }, 2);
        var result3 = solution.CanPlaceFlowers(new[] { 1 }, 1);
        var result4 = solution.CanPlaceFlowers(new[] { 0, 0, 0, 0 }, 1);
        var result5 = solution.CanPlaceFlowers(new[] { 0, 0, 1, 0, 1 }, 1);
        var result6 = solution.CanPlaceFlowers(new[] { 1, 0, 0, 0, 1, 0, 0 }, 2);
        var result7 = solution.CanPlaceFlowers(new[] { 0 }, 1);
        var result8 = solution.CanPlaceFlowers(new[] { 0, 1, 0 }, 1);
    }
}
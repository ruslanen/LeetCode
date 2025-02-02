namespace LeetCode._11_Container_With_Most_Water;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.MaxArea(new[] {1, 8, 6, 2, 5, 4, 8, 3, 7});
        var result2 = solution.MaxArea(new[] {1,1});
        var result3 = solution.MaxArea(new[] {1,1,2});
        var result4 = solution.MaxArea(new[] {1,2,4,3});
    }
}
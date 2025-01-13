namespace LeetCode._643_Maximum_Average_Subarray_I;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.FindMaxAverage(new[] { 1, 12, -5, -6, 50, 3 }, 4);
        var result2 = solution.FindMaxAverage(new[] { 5 }, 1);
        var result3 = solution.FindMaxAverage(new[] { 1,1,2,1,1,1,1,3 }, 3);
        var result4 = solution.FindMaxAverage(new[] { -1 }, 1);
        var result5 = solution.FindMaxAverage(new[] { 4,0,4,3,3 }, 5);
    }
}
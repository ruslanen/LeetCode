namespace LeetCode._228_Summary_Ranges;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.SummaryRanges(new[] { 0, 1, 2, 4, 5, 7 });
        var result2 = solution.SummaryRanges(new[] { 0, 2, 3, 4, 6, 8, 9 });
        var result3 = solution.SummaryRanges(new[] { 0 });
        var result4 = solution.SummaryRanges(new int[] { });
    }
}
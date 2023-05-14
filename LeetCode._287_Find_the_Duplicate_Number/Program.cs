namespace LeetCode._287_Find_the_Duplicate_Number;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.FindDuplicate(new[] {1, 3, 4, 2, 2});
        var result2 = solution.FindDuplicate(new[] {3, 1, 3, 4, 2});
    }
}
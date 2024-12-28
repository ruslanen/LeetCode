namespace LeetCode_1768_Merge_Strings_Alternately;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.MergeAlternately("abc", "pqr");
        var result2 = solution.MergeAlternately("ab", "pqrs");
        var result3 = solution.MergeAlternately("abcd", "pq");
    }
}
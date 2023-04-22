namespace LeetCode._120_Valid_Parentheses;

public class Program
{
    public static void Main()
    {
        var solution = new Solution(); 
        var result1 = solution.IsValid("()");
        var result2 = solution.IsValid("()[]{}");
        var result3 = solution.IsValid("(]");
        var result4 = solution.IsValid("(([]))");
        var result5 = solution.IsValid("(({}{}))");
        var result6 = solution.IsValid("(({}((}){}))");
    }
}
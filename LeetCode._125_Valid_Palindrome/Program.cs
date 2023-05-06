namespace LeetCode._125_Valid_Palindrome;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.IsPalindrome(" ");
        var result2 = solution.IsPalindrome("A man, a plan, a canal: Panama");
        var result3 = solution.IsPalindrome("race a car");
        var result4 = solution.IsPalindrome("0P");
    }
}
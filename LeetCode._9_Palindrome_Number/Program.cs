using LeetCode._9_Palindrome_Number;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.IsPalindrome(121);
        var result2 = solution.IsPalindrome(-121);
        var result3 = solution.IsPalindrome(12345321);
        var result4 = solution.IsPalindrome(10101);
    }
}
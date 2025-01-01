namespace LeetCode._1071_Greatest_Common_Divisor_of_Strings;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.GcdOfStrings("ABCABCABC", "ABC");
        var result2 = solution.GcdOfStrings("ABABAB", "ABAB");
        var result3 = solution.GcdOfStrings("LEET", "CODE");
        var result4 = solution.GcdOfStrings("AAAAAA", "A");
        var result5 = solution.GcdOfStrings("ABAB", "ABA");
        var result6 = solution.GcdOfStrings("ABAB", "ABAC");
        var result7 = solution.GcdOfStrings("TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXX");
    }
}
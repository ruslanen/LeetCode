namespace LeetCode._14_Longest_Common_Prefix;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.LongestCommonPrefix(new string[] {"flower", "flow", "flight"});
        var result2 = solution.LongestCommonPrefix(new string[] {"dog", "racecar", "car"});
        var result3 = solution.LongestCommonPrefix(new string[] {""});
        var result4 = solution.LongestCommonPrefix(new string[] {"a"});
        var result5 = solution.LongestCommonPrefix(new string[] {"a", ""});
    }
}
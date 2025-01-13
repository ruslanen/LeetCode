namespace LeetCode._151_Reverse_Words_in_a_String;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.ReverseWords("the sky is blue");
        var result2 = solution.ReverseWords("  hello world  ");
        var result3 = solution.ReverseWords("a good   example");
        var result5 = solution.ReverseWords("           a     good   example             ");
    }
}
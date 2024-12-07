namespace LeetCode._443_String_Compression;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.Compress(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });
        var result2 = solution.Compress(new char[] { 'a' });
        var result3 = solution.Compress(new char[] { 'a', 'a' });
        var result4 = solution.Compress(new char[] { 'a','b','b','b','b','b','b','b','b','b','b','b','b' });
        var result5 = solution.Compress(new char[] { 'a','a','b','b','b','b','b','b','b','b','b','b','b' });
        var result6 = solution.Compress(new char[] { 'a','a','a','b','b','c','b','c','b','b','b','b','b' });
        var result7 = solution.Compress(new char[] {  });
        var result8 = solution.Compress(new char[] { 'a','a','a','b','b','a','a' });
        var result9 = solution.Compress(new char[] { 'a','a','a','a','b','b','a','a' });
    }
}
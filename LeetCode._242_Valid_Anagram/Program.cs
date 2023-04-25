namespace LeetCode._242_Valid_Anagram;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.IsAnagram("anagram", "nagaram");
        var result2 = solution.IsAnagram("rat", "car");
    }
}
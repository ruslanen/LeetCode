namespace LeetCode._27_Remove_Element;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
        var result2 = solution.RemoveElement(new int[] { 3, 2, 2, 3 }, 3);
        var result3 = solution.RemoveElement(new int[] { 2 }, 2);
        var result4 = solution.RemoveElement(new int[] { 5,2 }, 2);
        var result5 = solution.RemoveElement(new int[] { 2,5 }, 2);
        var result6 = solution.RemoveElement(new int[] { 2 }, 3);
        var result7 = solution.RemoveElement(new int[] { 3,3 }, 3);
        var result8 = solution.RemoveElement(new int[] { 3,3 }, 5);
    }
}
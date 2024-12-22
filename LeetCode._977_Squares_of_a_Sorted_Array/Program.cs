namespace LeetCode._977_Squares_of_a_Sorted_Array;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.SortedSquares([-4, -1, 0, 3, 10]);
        var result2 = solution.SortedSquares([-7, -3, 2, 3, 11]);
        var result3 = solution.SortedSquares([-1]);
        var result4 = solution.SortedSquares([-2, -1]);
        var result5 = solution.SortedSquares([-1, 0, 1, 2]);
        var result6 = solution.SortedSquares([-10, -9, -7, -5, 0, 0, 10]);
        var result7 = solution.SortedSquares([-7, -3, 2, 3, 11]);
        var result8 = solution.SortedSquares([-1, 2, 2]);
    }
}
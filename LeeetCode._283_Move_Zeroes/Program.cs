namespace LeetCode._283_Move_Zeroes;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        solution.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
        solution.MoveZeroes(new int[] { 0 });
    }
}
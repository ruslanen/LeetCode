namespace LeetCode._733_Flood_Fill;

public class Program
{
    public static void Main()
    {
        var case1 = new int[][] {new int[] {1, 1, 1}, new int[] {1, 1, 0}, new int[] {1, 0, 1}};
        var case2 = new int[][] {new int[] {0, 0, 0}, new int[] {0, 0, 0}};
        var case3 = new int[][] {new int[] {0, 0, 0}, new int[] {1, 0, 0}};
        var solution = new Solution();
        solution.FloodFill(case1, 1, 1, 2);
        solution.FloodFill(case2, 0, 0, 0);
        solution.FloodFill(case3, 1, 0, 2);
    }
}
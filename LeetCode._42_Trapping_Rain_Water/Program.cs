namespace LeetCode._42_Trapping_Rain_Water;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var height1 = new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
        var height2 = new int[] {4, 2, 0, 3, 2, 5};
        var height3 = new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
        var height4 = new int[] {5, 4, 1, 2};
        var height5 = new int[] {6, 4, 2, 0, 3, 2, 0, 3, 1, 4, 5, 3, 2, 7, 5, 3, 0, 1, 2, 1, 3, 4, 6, 8, 1, 3};
        var height6 = new int[] {3, 0, 1, 2, 0, 1};
         var result1 = solution.TrapV3(height1);
        // var result2 = solution.TrapV3(height2);
        // var result3 = solution.TrapV3(height3);
        // var result4 = solution.TrapV3(height4);
        // var result5 = solution.TrapV3(height5);
        //var result6 = solution.TrapV3(height6);
    }
}
namespace LeetCode._1732_Find_the_Highest_Altitude;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.LargestAltitude(new int[] { -5, 1, 5, 0, -7 });
        var result2 = solution.LargestAltitude(new int[] { -4, -3, -2, -1, 4, 3, 2 });
        var result3 = solution.LargestAltitude(new int[] { -4, 0, 100 });
        var result4 = solution.LargestAltitude(new int[] { 1 });
    }
}
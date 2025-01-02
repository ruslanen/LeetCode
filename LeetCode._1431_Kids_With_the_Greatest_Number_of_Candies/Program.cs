namespace LeetCode._1431_Kids_With_the_Greatest_Number_of_Candies;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.KidsWithCandies(new[] { 2, 3, 5, 1, 3 }, 3);
        var result2 = solution.KidsWithCandies(new[] { 4,2,1,1,2 }, 1);
        var result3 = solution.KidsWithCandies(new[] { 12,1,12 }, 10);
        var result4 = solution.KidsWithCandies(new[] { 1,1,1 }, 100);
    }
}
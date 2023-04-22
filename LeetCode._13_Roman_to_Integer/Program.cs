namespace LeetCode._13_Roman_to_Integer;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.RomanToInt("III");       // 3
        var result2 = solution.RomanToInt("LVIII");     // 58 
        var result3 = solution.RomanToInt("MCMXCIV");   // 1994
        var result4 = solution.RomanToInt("CM");        // 900
        var result5 = solution.RomanToInt("IV");        // 4
    }
}
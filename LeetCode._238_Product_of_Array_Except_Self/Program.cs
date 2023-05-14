namespace LeetCode._238_Product_of_Array_Except_Self;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.ProductExceptSelf(new[] {1, 2, 3, 4});
        var result2 = solution.ProductExceptSelf(new[] {-1, 1, 0, -3, 3});
    }
}
namespace LeetCode._167_Two_Sum_II_Input_Array_Is_Sorted;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result1 = solution.TwoSum(new[] {2, 7, 11, 15}, 9); // [0, 1]
        var result2 = solution.TwoSum(new[] {2, 3, 4}, 6); // [1, 3]
        var result3 = solution.TwoSum(new[] {-1, 0}, -1); // [0, 1]
        var result4 = solution.TwoSum(new[] {0, 0, 3, 4}, 0); // [1, 2]
        var result5 = solution.TwoSum(new[] {0, 0, 1, 1, 4, 5}, 6); // [3, 6]
    }
}
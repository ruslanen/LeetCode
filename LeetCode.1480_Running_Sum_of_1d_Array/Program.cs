public class Program
{
    public static void Main()
    {
        var data = new int[] {1, 2, 3, 4};
        var solution = new Solution();
        var result = solution.RunningSum(data);
        Console.WriteLine(string.Join(", ", result));
    }
}

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        var result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                result[i] += nums[j];
            }
        }

        return result;
    } 
}



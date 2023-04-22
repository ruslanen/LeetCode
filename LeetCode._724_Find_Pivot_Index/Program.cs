public class Program
{
    public static void Main()
    {
        var nums = new int[] {1, 7, 3, 6, 5, 6};
        var solution = new Solution();
        var result = solution.PivotIndex(nums);
        Console.WriteLine(result);
    }
}

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var index = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            var left = 0;
            for (int j = 0; j < i; j++)
            {
                left += nums[j];
            }

            var right = 0;
            for (int j = i + 1; j < nums.Length; j++)
            {
                right += nums[j];
            }

            if (left == right)
            {
                index = i;
                break;
            }
        }

        return index;
    }
}
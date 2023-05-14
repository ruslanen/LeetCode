namespace LeetCode._238_Product_of_Array_Except_Self;

public class Solution
{
    public int[] ProductExceptSelfV2(int[] nums)
    {
        var result = Enumerable.Repeat(1, nums.Length).ToArray();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    result[i] = result[i] * nums[j];
                }
            }
        }

        return result;
    }

    public int[] ProductExceptSelfV3(int[] nums)
    {
        var result = new int[nums.Length];
        var product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product = product * nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = product / (nums[i] == 0 ? 1 : nums[i]);
        }

        return result;
    }

    // O(n)
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        var prefix = 1;
        // В начале умножаем число на предыдущее по порядку начиная с 1
        // (последнее число исходного массива не будет учитываться
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = prefix;
            prefix = prefix * nums[i];
        }

        var postfix = 1;
        // Далее выполняем аналогичную операцию в обратном порядке
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] = result[i] * postfix;
            postfix = postfix * nums[i];
        }

        return result;
    }
}
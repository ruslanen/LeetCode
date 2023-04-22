namespace LeetCode._70_Climbing_Stairs;

public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n < 1)
            return 0;

        if (n == 1)
            return 1;

        if (n == 2)
            return 2;

        return ClimbStairs(n - 2) + ClimbStairs(n - 1);
    }
    
    public int ClimbStairsV2(int n)
    {
        if (n == 0)
            return 0;

        var firstOne = 1;
        var secondOne = 1;
        for (int i = 1; i < n; i++)
        {
            var temp = secondOne;
            secondOne = firstOne + secondOne;
            firstOne = temp;
        }

        return secondOne;
    }
}
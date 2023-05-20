namespace LeetCode._11_Container_With_Most_Water;

public class Solution
{
    // O(n)
    public int MaxArea(int[] height)
    {
        // В основе алгоритма лежат два указателя - левый и правый.
        // Изначально левый - первый элемент.
        // правый - последний.
        // Алгоритм будет увеличивать левый указатель в случае, если правая высота больше, чем левая
        // или увеличивать правый указатель в случае, если левая высота больше, чем правая.
        // Здесь же, сразу будет вычислять площадь и максимум.
        // Алгоритм на каждом шаге будет работать только с максимальным левым или правым указателем,
        // что позволит не выполнять лишние вычисления.
        var li = 0;
        var ri = height.Length - 1;
        var max = 0;
        while (li != height.Length - 1 && ri != 0)
        {
            var left = height[li];
            var right = height[ri];
            var val = Math.Min(left, right) * (ri - li);

            if (val > max)
                max = val;

            if (right > left)
            {
                li++;
            }
            else
            {
                ri--;
            }
        }

        return max;
    }
    
    // O(n^2)
    // Time Limit Exceeded
    public int MaxAreaV1(int[] height)
    {
        var max = 0;
        for (int i = 0; i < height.Length; i++)
        {
            for (int j = i; j < height.Length; j++)
            {
                var value = Math.Min(height[i], height[j]) * (j - i);
                if (value > max)
                {
                    max = value;
                }
            }
        }

        return max;
    }
}
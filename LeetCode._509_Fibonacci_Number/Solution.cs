namespace LeetCode._509_Fibonacci_Number;

public class Solution
{
    /// <summary>
    /// Находит число Фибоначчи.
    /// Число Фибоначчи - это сумма двух предыдущих чисел.
    /// </summary>
    public int Fib(int n)
    {
        if (n < 1)
            return 0;
    
        if (n == 1)
            return 1;
    
        return Fib(n - 2) + Fib(n - 1);
    }

    /// <summary>
    /// Более оптимальное решение через цикл
    /// </summary>
    public int FibV2(int n)
    {
        if (n == 0)
            return 0;

        var firstOne = 0;
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
namespace LeetCode._278_First_Bad_Version;

public class Program
{
    public static void Main()
    {
        var solution = new Solution();
        var result = solution.FirstBadVersion(111);
        Console.WriteLine("Bad version: {0}", result);
    }
}

public class Solution
{
    public int FirstBadVersion(int n)
    {
        var result = FirstBadVersionInternal(n, 0);
        return result;
    }

    public int FirstBadVersionInternal(int n, int previousChecked)
    {
        var step = Math.Abs(n - previousChecked) / 2;
        if (step == 0)
        {
            step = 1;
        }
        
        if (IsBadVersion(n))
        {
            return FirstBadVersionInternal(n - step, n);
        }

        // Если предыдущая версия больше, чем текущая, то значит, что она была забагована.
        // Также, если шаг между этими версиями равен 1, то мы нашли первую забагованную версию - это предыдущая.
        if (previousChecked > n && previousChecked - n == 1)
        {
            return previousChecked;
        }
            
        // Если версия не содержит ошибок, то значит идем вверх
        return FirstBadVersionInternal(n + step, n);
    }

    private bool IsBadVersion(int version)
    {
        return version >= 102;
    }
}
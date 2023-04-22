namespace LeetCode._9_Palindrome_Number;

public class Solution
{
    /// <summary>
    /// Определить является ли число палиндромом.
    /// Читается слева направо и справа налево одинаково.
    /// Алгоритм имеет сложность O(n).
    /// </summary>
    public bool IsPalindrome(int x)
    {
        // Отрицательные числа не являются палиндромами
        if (x < 0)
        {
            return false;
        }

        // 1. Находим число цифр в числе
        var countOfNumbers = 0;
        var tmpNumber = x;
        while (tmpNumber != 0)
        {
            tmpNumber /= 10;
            countOfNumbers++;
        }
        
        // 2. Заполняем массив числами
        var numberAsArray = new int[countOfNumbers];
        var nextIndex = 0;
        var number = x;
        while (number != 0)
        {
            numberAsArray[nextIndex++] = number % 10;
            number /= 10;
        }

        // 3. Читаем массив слева направо и справа налево для определения равенства чисел по индексам
        for (int i = 0, j = countOfNumbers - 1; i < countOfNumbers; i++, j--)
        {
            if (numberAsArray[i] != numberAsArray[j])
                return false;
        }

        return true;
    }
}
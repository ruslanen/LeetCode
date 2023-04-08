namespace LeetCode._14_Longest_Common_Prefix;

public class Solution
{
    /// <summary>
    /// В массиве строк находит идентичные префиксы для каждой строки массива.
    /// Результат не фиксируется, если префикс отсутствует хотя бы в одной строке.
    /// </summary>
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return string.Empty;

        if (strs[0].Length == 0)
            return string.Empty;
        
        // Так как в условиях задачи все строки массива должны иметь одинаковый префикс,
        // это значит, что мы можем просто взять первый элемент и сравнивать каждую строку в массиве с этим первым элементом
        char charToCompare = strs[0][0];
        string result = string.Empty;
        int currentWordIndex = 1;
        int currentLetterIndex = 0;
        while (true)
        {
            if (currentWordIndex == strs.Length)
            {
                // Если мы проверили букву в каждом слове из массива,
                // то сбрасываем индекс слова на 0, чтобы начать заново
                // и перейти к проверке следующей буквы
                currentWordIndex = 0;
                result += charToCompare;
                
                // Итерируем до тех пор, пока не переберем все буквы первой строки
                if (strs[0].Length == currentLetterIndex + 1)
                    break;
                
                charToCompare = strs[0][++currentLetterIndex];
            }

            var word = strs[currentWordIndex++];
            
            // Итерируем до тех пор, пока не переберем все буквы первой строки
            if (word.Length == currentLetterIndex)
                break;

            if (word[currentLetterIndex] != charToCompare)
                break;
        }

        return result;
    }
}
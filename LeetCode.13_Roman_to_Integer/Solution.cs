namespace LeetCode._13_Roman_to_Integer;

public class Solution
{
    /// <summary>
    /// Преобразует строковое римское число в арабское числовое значение.
    /// 
    /// I             1
    /// V             5
    /// X             10
    /// L             50
    /// C             100
    /// D             500
    /// M             1000
    /// </summary>
    public int RomanToInt(string s)
    {
        var result = 0;
        var i = 0;
        // Итерируем до тех пор, пока не пройдем по всем символам строки
        while (i != s.Length)
        {
            // Берем очередной символ
            var intValue = ConvertRomanToArabic(s[i++]);
            if (i != s.Length)
            {
                // Если символ не последний, то дополнительно берем следующий символ
                var nextIntValue = ConvertRomanToArabic(s[i]);
                if (intValue == 1 && (nextIntValue == 5 || nextIntValue == 10) ||
                    intValue == 10 && (nextIntValue == 50 || nextIntValue == 100) ||
                    intValue == 100 && (nextIntValue == 500 || nextIntValue == 1000))
                {
                    // I (1)   can be placed before V (5)   and X (10)   to make 4 and 9. 
                    // X (10)  can be placed before L (50)  and C (100)  to make 40 and 90. 
                    // C (100) can be placed before D (500) and M (1000) to make 400 and 900.
                    result += nextIntValue - intValue;
                    i++;
                }
                else
                {
                    result += intValue;
                }
            }
            else
            {
                result += intValue;
            }
        }

        return result;
    }

    private int ConvertRomanToArabic(char charNumber) => charNumber switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => throw new ArgumentOutOfRangeException(nameof(charNumber), charNumber, "Number is not Roman")
    };
}
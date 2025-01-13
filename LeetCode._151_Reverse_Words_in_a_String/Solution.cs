namespace LeetCode._151_Reverse_Words_in_a_String;

public class Solution
{
    // Solution 1 (with extra space)
    // public string ReverseWords(string s)
    // {
    //     return string.Join(" ", s.Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => x != "").Reverse());
    // }
    
    // Solution 2
    // public string ReverseWords(string s)
    // {
    //     var end = s.Length;
    //     var writeIndex = 0;
    //     var result = s.ToCharArray();
    //     for (int i = result.Length - 1; i >= 0; i--)
    //     {
    //         var wordLength = end - i - 1;
    //         if (s[i] == ' ')
    //         {
    //             var word = s.Substring(i + 1, wordLength);
    //             if (word == " ")
    //                 continue;
    //             
    //             end = i;
    //
    //             for (int j = 0; j < word.Length; j++)
    //             {
    //                 result[writeIndex++] = word[j];
    //             }
    //
    //             if (word != "")
    //                 result[writeIndex++] = ' ';
    //         }
    //         else if (i == 0)
    //         {
    //             var word = s.Substring(i, end - i);
    //             
    //             for (int j = 0; j < word.Length; j++)
    //             {
    //                 result[writeIndex++] = word[j];
    //             }
    //         }
    //     }
    //
    //     return string.Join("", result[..writeIndex]).Trim();
    // }
    
    // Solution 3 (O(1) space)
    public string ReverseWords(string s)
    {
        var chars = s.ToCharArray();
        int length = RemoveExtraSpaces(chars);   // Удаляем лишние пробелы и получаем новую длину
        Reverse(chars, 0, length - 1);           // Переворачиваем весь массив
        ReverseEachWord(chars, length);          // Переворачиваем каждое слово

        return new string(chars, 0, length);
    }

    // Удаление лишних пробелов (in-place)
    private int RemoveExtraSpaces(char[] chars)
    {
        int writeIndex = 0;
        bool isSpace = true;

        for (int readIndex = 0; readIndex < chars.Length; readIndex++)
        {
            if (chars[readIndex] != ' ')
            {
                if (writeIndex > 0 && isSpace)
                {
                    chars[writeIndex++] = ' ';
                }
                chars[writeIndex++] = chars[readIndex];
                isSpace = false;
            }
            else
            {
                isSpace = true;
            }
        }

        return writeIndex;
    }

    // Переворот части массива
    private void Reverse(char[] chars, int start, int end)
    {
        while (start < end)
        {
            (chars[start], chars[end]) = (chars[end], chars[start]);
            start++;
            end--;
        }
    }

    // Переворот каждого слова
    private void ReverseEachWord(char[] chars, int length)
    {
        int start = 0;
        for (int end = 0; end <= length; end++)
        {
            if (end == length || chars[end] == ' ')
            {
                Reverse(chars, start, end - 1);
                start = end + 1;
            }
        }
    }
}
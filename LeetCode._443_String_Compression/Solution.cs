namespace LeetCode._443_String_Compression;

public class Solution
{
    // public int Compress(char[] chars)
    // {
    //     if (chars.Length == 0)
    //     {
    //         return 0;
    //     }
    //     
    //     if (chars.Length == 1)
    //     {
    //         return 1;
    //     }
    //     
    //     var counter = 1;
    //     var startIndex = 0;
    //     for (int i = 0; i < chars.Length - 1; i++)
    //     {
    //         if (chars[i] != chars[i + 1])
    //         {
    //             if (counter > 1)
    //             {
    //                 Write(chars, counter, startIndex + 1);
    //             }
    //             
    //             counter = 0;
    //             startIndex = i + 1;
    //         }
    //
    //         counter++;
    //     }
    //
    //     Write(chars, counter, startIndex + 1);
    //     return startIndex + 1 + counter.ToString().Length;
    // }

    // public int Compress(char[] chars)
    // {
    //     if (chars.Length == 0)
    //     {
    //         return 0;
    //     }
    //     
    //     if (chars.Length == 1)
    //     {
    //         return 1;
    //     }
    //     
    //     var counter = 1;
    //     var startIndex = 0;
    //     for (int i = 0; i < chars.Length - 1; i++)
    //     {
    //         if (chars[i] != chars[i + 1])
    //         {
    //             if (counter > 1)
    //             {
    //                 Write(chars, counter, startIndex + 1);
    //                 var c = 0;
    //                 for (int j = startIndex + 2; j < counter; j++)
    //                 {
    //                     c++;
    //                     for (int k = startIndex + 2; k < chars.Length - 1; k++)
    //                     {
    //                         chars[k] = chars[k + 1];
    //                     }
    //
    //                     chars[chars.Length - c] = '\0';
    //                 }
    //
    //                 i = i - c;
    //                 startIndex = i + 1;
    //             }
    //             else
    //             {
    //                 startIndex = i + 1;
    //             }
    //             
    //             counter = 0;
    //         }
    //
    //         counter++;
    //     }
    //
    //     Write(chars, counter, startIndex + 1);
    //     return startIndex + 1 + counter.ToString().Length;
    // }
    //
    // private void Write(char[] array, int number, int index)
    // {
    //     // TODO: Алгоритм на основе делений
    //     var stringNumber = number.ToString();
    //     for (int i = 0; i < stringNumber.Length; i++)
    //     {
    //         array[index++] = stringNumber[i];
    //     }
    // }
    
    public int Compress(char[] chars)
    {
        int writeIndex = 0;
        int readIndex = 0;

        while (readIndex < chars.Length)
        {
            char currentChar = chars[readIndex];
            int count = 0;
            
            while (readIndex < chars.Length && chars[readIndex] == currentChar)
            {
                readIndex++;
                count++;
            }
            
            chars[writeIndex++] = currentChar;
            
            if (count > 1)
            {
                foreach (char c in count.ToString())
                {
                    chars[writeIndex++] = c;
                }
            }
        }

        return writeIndex;
    }
}
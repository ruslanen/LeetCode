using System.Text;

namespace LeetCode_1768_Merge_Strings_Alternately;

public class Solution
{
    // public string MergeAlternately(string word1, string word2)
    // {
    //     var result = new StringBuilder();
    //     var max = Math.Max(word1.Length, word2.Length);
    //     for (int i = 0; i < max; i++)
    //     {
    //         if (i < word1.Length)
    //         {
    //             result.Append(word1[i]);
    //         }
    //
    //         if (i < word2.Length)
    //         {
    //             result.Append(word2[i]);
    //         }
    //     }
    //
    //     return result.ToString();
    // }

    /// <summary>
    /// Better solution
    /// </summary>
    public string MergeAlternately(string word1, string word2)
    {
        var result = new StringBuilder();
        int i = 0;
        bool hasChar1 = true, hasChar2 = true;
        while (hasChar1 || hasChar2)
        {
            hasChar1 = i < word1.Length;
            if (hasChar1)
                result.Append(word1[i]);

            hasChar2 = i < word2.Length;
            if (hasChar2)
                result.Append(word2[i]);

            i++;
        }

        return result.ToString();
    }
}
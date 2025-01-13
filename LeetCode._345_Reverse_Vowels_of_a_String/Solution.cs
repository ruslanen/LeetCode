using System.Text;

namespace LeetCode._345_Reverse_Vowels_of_a_String;

public class Solution
{
    public string ReverseVowels(string s)
    {
        var result = new StringBuilder();
        var vowels = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (IsVowel(char.ToLower(s[i])))
            {
                vowels.Push(s[i]);
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (IsVowel(char.ToLower(s[i])))
            {
                result.Append(vowels.Pop());
            }
            else
            {
                result.Append(s[i]);
            }
        }

        return result.ToString();
    }

    private bool IsVowel(char c) => new char[] { 'a', 'e', 'i', 'o', 'u' }.ToHashSet().Contains(c);
}